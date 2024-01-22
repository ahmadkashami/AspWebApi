using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace PokemomReviewApp.DatabaseConfig
{
    public class PokemonCategoryEntityConfig : IEntityTypeConfiguration<PokemonCategory>
    {
        public void Configure(EntityTypeBuilder<PokemonCategory> builder)
        {
            builder.HasKey(pc => new { pc.PokemonId, pc.CategoryId });
            builder.HasOne(p => p.Pokemon)
                    .WithMany(pc => pc.PokemonCategories)
                    .HasForeignKey(p => p.PokemonId);
            builder.HasOne(p => p.Category)
                    .WithMany(pc => pc.PokemonCategories)
                    .HasForeignKey(c => c.CategoryId);
        }
    }
}
