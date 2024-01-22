using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace PokemomReviewApp.DatabaseConfig
{
    public class PokemonOwnerEntityConfig : IEntityTypeConfiguration<PokemonOwner>
    {
        public void Configure(EntityTypeBuilder<PokemonOwner> builder)
        {

            builder.HasKey(po => new { po.PokemonId, po.OwnerId });
            builder .HasOne(p => p.Pokemon)
                    .WithMany(pc => pc.PokemonOwners)
                    .HasForeignKey(p => p.PokemonId);
            builder.HasOne(p => p.Owner)
                    .WithMany(pc => pc.PokemonOwners)
                    .HasForeignKey(c => c.OwnerId);
        }
    }
}
