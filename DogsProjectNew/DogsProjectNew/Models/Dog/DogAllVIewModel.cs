using System.ComponentModel.DataAnnotations;

namespace DogsProjectNew.Models.Dog
{
    public class DogAllVIewModel
    {
        public int Id { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; } = null!;

        [Display(Name = "Age")]
        public string Age { get; set; }


        [Display(Name = "Breed")]
        public string Breed { get; set; } = null!;

        [Display(Name = "Dog Picture")]
        public string? Picture { get; set; }

    }
}
