<<<<<<< HEAD
using VoeAirlinesSenai.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace VoeAirlinesSenai.EntityConfigurations;
=======
using VoeAirlinesSenai.Contexts;
using VoeAirlinesSenai.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VoeAirlinesSenai.EntityConfigurations;

>>>>>>> 00825fd5e8b29a97ad86c727a2dd0b07d6ba36d7
public class ManutencaoConfiguration : IEntityTypeConfiguration<Manutencao>
{
    public void Configure(EntityTypeBuilder<Manutencao> builder)
    {
        builder.ToTable("Manutencoes");

        builder.HasKey(m => m.Id);

        builder.Property(m => m.DataHora)
               .IsRequired();
<<<<<<< HEAD

=======
        
>>>>>>> 00825fd5e8b29a97ad86c727a2dd0b07d6ba36d7
        builder.Property(m => m.Tipo)
               .IsRequired();

        builder.Property(m => m.Observacoes)
<<<<<<< HEAD
                .HasMaxLength(100);
=======
               .HasMaxLength(100);
>>>>>>> 00825fd5e8b29a97ad86c727a2dd0b07d6ba36d7
    }
}