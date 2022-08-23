<<<<<<< HEAD
=======
using VoeAirlinesSenai.Contexts;
>>>>>>> 00825fd5e8b29a97ad86c727a2dd0b07d6ba36d7
using VoeAirlinesSenai.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace VoeAirlinesSenai.EntityConfigurations;
<<<<<<< HEAD
=======

>>>>>>> 00825fd5e8b29a97ad86c727a2dd0b07d6ba36d7
public class PilotoConfiguration : IEntityTypeConfiguration<Piloto>
{
    public void Configure(EntityTypeBuilder<Piloto> builder)
    {
<<<<<<< HEAD
        builder.ToTable("Piloto");
        builder.HasKey(p => p.Id);
        builder.Property(p => p.Nome)
               .IsRequired()
               .HasMaxLength(80);
=======
        builder.ToTable("Pilotos");

        builder.HasKey(p => p.Id);

        builder.Property(p => p.Nome)
               .IsRequired()
               .HasMaxLength(100);

>>>>>>> 00825fd5e8b29a97ad86c727a2dd0b07d6ba36d7
        builder.Property(p => p.Matricula)
               .IsRequired()
               .HasMaxLength(10);

        builder.HasIndex(p => p.Matricula)
               .IsUnique();
    }
}