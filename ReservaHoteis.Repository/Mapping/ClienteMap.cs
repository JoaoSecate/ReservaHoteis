using ReservaHoteis.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ReservaHoteis.Repository.Mapping
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Cliente");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Nome)
                .IsRequired()
                .HasColumnType("varchar(45)");

            builder.Property(prop => prop.Documento)
                .IsRequired()
                .HasColumnType("varchar(45)");

            builder.Property(prop => prop.Email)
                .IsRequired()
                .HasColumnType("varchar(45)");

            builder.Property(prop => prop.Senha)
                .IsRequired()
                .HasColumnType("varchar(45)");
        }
    }
}