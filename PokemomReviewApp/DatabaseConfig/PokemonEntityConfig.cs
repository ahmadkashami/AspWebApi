using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace PokemomReviewApp.DatabaseConfig
{
    public class PokemonEntityConfig: IEntityTypeConfiguration<Pokemon>
    {
                public void Configure(EntityTypeBuilder<Pokemon> builder)
                {
                    throw new NotImplementedException();
                }
    }
}
