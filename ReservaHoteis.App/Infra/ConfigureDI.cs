﻿using AutoMapper;
using ReservaHoteis.App.Cadastros;
using ReservaHoteis.App.Models;
using ReservaHoteis.App.User;
using ReservaHoteis.Domain.Base;
using ReservaHoteis.Domain.Entities;
using ReservaHoteis.Repository.Context;
using ReservaHoteis.Repository.Repository;
using ReservaHoteis.Service.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualBasic.Logging;
using System.Diagnostics.Contracts;

namespace ReservaHoteis.App.Infra
{
    public static class ConfigureDI
    {
        public static ServiceCollection? Services;

        public static ServiceProvider? ServicesProvider;

        public static void ConfiguraServices()
        {
            Services = new ServiceCollection();
            Services.AddDbContext<MySqlContext>(options =>
            {
                var strCon = "Server = localhost; Port = 3306; Database = ReservaHoteis; Uid = root; Pwd =";//File.ReadAllText("Config/DatabaseSettings.txt");
                options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
                options.EnableSensitiveDataLogging();

                options.UseMySql(strCon, ServerVersion.AutoDetect(strCon), opt =>
                {
                    opt.CommandTimeout(180);
                    opt.EnableRetryOnFailure(5);
                });
            });

            // Repositories
            Services.AddScoped<IBaseRepository<Cidade>, BaseRepository<Cidade>>();
            Services.AddScoped<IBaseRepository<Cliente>, BaseRepository<Cliente>>();
            Services.AddScoped<IBaseRepository<Contrato>, BaseRepository<Contrato>>();
            Services.AddScoped<IBaseRepository<Hotel>, BaseRepository<Hotel>>();
            Services.AddScoped<IBaseRepository<Avaliacao>, BaseRepository<Avaliacao>>();
            Services.AddScoped<IBaseRepository<Usuario>, BaseRepository<Usuario>>();

            // Services
            Services.AddScoped<IBaseService<Cidade>, BaseService<Cidade>>();
            Services.AddScoped<IBaseService<Cliente>, BaseService<Cliente>>();
            Services.AddScoped<IBaseService<Contrato>, BaseService<Contrato>>();
            Services.AddScoped<IBaseService<Hotel>, BaseService<Hotel>>();
            Services.AddScoped<IBaseService<Avaliacao>, BaseService<Avaliacao>>();
            Services.AddScoped<IBaseService<Usuario>, BaseService<Usuario>>();

            // Formulários
            Services.AddTransient<Login, Login>();
            Services.AddTransient<CadastroCidade, CadastroCidade>();
            Services.AddTransient<CadastroCliente, CadastroCliente>();
            Services.AddTransient<CadastroContrato, CadastroContrato>();
            Services.AddTransient<CadastroHotel, CadastroHotel>();
            Services.AddTransient<CadastroAvaliacao, CadastroAvaliacao>();

            // Mapping
            Services.AddSingleton(new MapperConfiguration(config =>
            {
                config.CreateMap<Cliente, ClienteModel>();
                config.CreateMap<Cidade, CidadeModel>()
                    .ForMember(d => d.NomeEstado, d => d.MapFrom(x => $"{x.Nome}/{x.Estado}"));
               
                config.CreateMap<Contrato, ContratoModel>()
                    .ForMember(d => d.idHotel, d => d.MapFrom(x => x.Hotel!.Id))
                    .ForMember(d => d.Hotel, d => d.MapFrom(x => $"{x.Hotel!.Nome}"))
                    .ForMember(d => d.idCliente, d => d.MapFrom(x => x.Cliente!.Id))
                    .ForMember(d => d.Cliente, d => d.MapFrom(x => $"{x.Cliente!.Nome}"));

                config.CreateMap<Hotel, HotelModel>()
                    .ForMember(d => d.idCidade, d => d.MapFrom(x => x.Cidade!.Id))
                    .ForMember(d => d.Cidade, d => d.MapFrom(x => $"{x.Cidade!.Nome}/{x.Cidade!.Estado}"));                  

                config.CreateMap<Avaliacao, AvaliacaoModel>()
                    .ForMember(d => d.idHotel, d => d.MapFrom(x => x.Hotel!.Id))
                    .ForMember(d => d.Hotel, d => d.MapFrom(x => $"{x.Hotel!.Nome}"))
                    .ForMember(d => d.idCliente, d => d.MapFrom(x => x.Cliente!.Id))
                    .ForMember(d => d.Cliente, d => d.MapFrom(x => $"{x.Cliente!.Nome}"));

            }).CreateMapper());
            

            ServicesProvider = Services.BuildServiceProvider();
        }
    }
}

