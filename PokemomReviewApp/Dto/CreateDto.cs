using System.ComponentModel.DataAnnotations;

namespace PokemomReviewApp.Dto
{
    public class CreateDto
    {
        public int Id { get; set; }
        public string Name { get; set; }


        [Required]
        public string BirthDate { get; set; }
    }
}
