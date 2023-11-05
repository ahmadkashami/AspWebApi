using AutoMapper;
using PokemomReviewApp.Dto;
using PokemomReviewApp.Models;

namespace PokemomReviewApp.Helper
{
    public class MappingProfiles:Profile
    {
        public MappingProfiles()
        {
            CreateMap<Pokemon, PokemonDto>();
            CreateMap<Category,CategoryDto>();
            CreateMap<Country, CountryDto>();
            CreateMap<Owner, OwnerDto>();
            
        }
    }
}
