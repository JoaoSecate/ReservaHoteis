using ReservaHoteis.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ReservaHoteis.Repository.Mapping
{
    public class AvaliacaoMap : IEntityTypeConfiguration<Avaliacao>
    {
        public void Configure(EntityTypeBuilder<Avaliacao> builder)
        {
            builder.ToTable("Avaliacao");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Nota)
                .IsRequired()
                .HasColumnType("decimal(2,1)");

            builder.Property(prop => prop.Descricao);

            builder.HasOne(prop => prop.Cliente);
        }
    }
}