using System.ComponentModel.DataAnnotations;

namespace DECO_Pets.Models
{
    public class Species
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [Display(Name = "Species")]
        public string? NameSpecies { get; set; }

    }
}
