using PokemomReviewApp.Models;

namespace PokemomReviewApp.Interfaces
{
    public interface ICategoryRepository
    {
        ICollection<Category> GetCategories();
        Category GetCategory(int id);
        Category GetCategory(string name);

        bool CategoriesExists(int id);
        ICollection<Pokemon> GetPokemonByCategory(int catId);
    }
}
