using ReservaHoteis.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ReservaHoteis.Repository.Mapping
{
    public class ContratoMap : IEntityTypeConfiguration<Contrato>
    {
        public void Configure(EntityTypeBuilder<Contrato> builder)
        {
            builder.ToTable("Contrato");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.ValorTotal)
                .IsRequired()
                .HasColumnType("decimal(5,2)");

            builder.Property(prop => prop.Data)
                .IsRequired();

            builder.HasOne(prop => prop.Cliente);

            builder.HasOne(prop => prop.Hotel);
        }
    }
    public class ContratoServicoMap : IEntityTypeConfiguration<ContratoServico>
    {
        public void Configure(EntityTypeBuilder<ContratoServico> builder)
        {
            builder.ToTable("ContratoServico");

            builder.HasKey(prop => prop.Id);

            builder.HasOne(prop => prop.Contrato);

            builder.HasMany(prop => prop.Servico);
        }
    }
}