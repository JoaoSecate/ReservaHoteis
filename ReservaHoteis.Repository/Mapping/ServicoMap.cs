using ReservaHoteis.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ReservaHoteis.Repository.Mapping
{
    public class ServicoMap : IEntityTypeConfiguration<Servico>
    {
        public void Configure(EntityTypeBuilder<Servico> builder)
        {
            builder.ToTable("Servico");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Nome)
                .IsRequired()
                .HasColumnType("varchar(45)");

            builder.Property(prop => prop.Descricao)
                .IsRequired()
                .HasColumnType("varchar(45)");

            builder.Property(prop => prop.Valor);

            builder.Property(prop => prop.Tipo);

            builder.HasOne(prop => prop.Hotel);
        }
    }
}