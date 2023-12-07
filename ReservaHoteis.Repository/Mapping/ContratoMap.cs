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
}