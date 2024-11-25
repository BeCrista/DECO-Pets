using System.ComponentModel.DataAnnotations;

namespace DECO_Pets.Models
{
    public class Weight
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [Display(Name = "Weight")]
        public string? WeightDescription { get; set; }
    }
}
