using ReservaHoteis.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ReservaHoteis.Repository.Mapping
{
    public class HotelMap : IEntityTypeConfiguration<Hotel>
    {
        public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            builder.ToTable("Hotel");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Nome)
                .IsRequired()
                .HasColumnType("varchar(45)");

            builder.Property(prop => prop.Classificacao);

            builder.Property(prop => prop.Endereco)
                .IsRequired()
                .HasColumnType("varchar(45)");

            builder.HasOne(prop => prop.Cidade);
        }
    }
}