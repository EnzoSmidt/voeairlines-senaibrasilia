
using VoeAirlinesSenai.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace VoeAirlinesSenai.EntityConfigurations;
public class AeronaveConfiguration : IEntityTypeConfiguration<Aeronave>
{
    public void Configure(EntityTypeBuilder<Aeronave> builder)
    {
        builder.ToTable("Aeronaves");
        builder.HasKey(a => a.Id);
        builder.Property(a => a.Fabricante)
               .IsRequired()
               .HasMaxLength(50);
        builder.Property(a => a.Modelo)
               .IsRequired()
               .HasMaxLength(50);
        builder.Property(a => a.Codigo)
               .IsRequired()
               .HasMaxLength(10);

        //Agora é Sério ---Chegou o Relacionamento
        /*
          https://brasilescola.uol.com.br/matematica/conjunto.htm
        */
        //Many    One
        builder.HasMany(a => a.Manutencoes)
               .WithOne(m => m.Aeronave)
               .HasForeignKey(m => m.AeronaveId);

    }
}















/*using VoeAirlinesSenai.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CiaAerea.EntityConfigurations;
=======

using VoeAirlinesSenai.Contexts;
using VoeAirlinesSenai.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VoeAirlinesSenai.EntityConfigurations;

>>>>>>> 00825fd5e8b29a97ad86c727a2dd0b07d6ba36d7

public class AeronaveConfiguration : IEntityTypeConfiguration<Aeronave>
{
    public void Configure(EntityTypeBuilder<Aeronave> builder)
    {
        builder.ToTable("Aeronaves");

        builder.HasKey(a => a.Id);

        builder.Property(a => a.Fabricante)
               .IsRequired()
               .HasMaxLength(50);

        builder.Property(a => a.Modelo)
               .IsRequired()
               .HasMaxLength(50);

        builder.Property(a => a.Codigo)
               .IsRequired()
               .HasMaxLength(10);

        builder.HasMany(a => a.Manutencoes)
               .WithOne(m => m.Aeronave)
               .HasForeignKey(m => m.AeronaveId);
    }
<<<<<<< HEAD
}

*/
=======
}
>>>>>>> 00825fd5e8b29a97ad86c727a2dd0b07d6ba36d7
