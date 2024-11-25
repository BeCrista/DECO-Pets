using System.ComponentModel.DataAnnotations;

namespace DECO_Pets.Models
{
    public class Age
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [Display(Name ="Age")]
        public string? AgeDescription { get; set; }
    }
}
