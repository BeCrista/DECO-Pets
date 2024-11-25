using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DECO_Pets.Models
{
    public class Race
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Descricao { get; set; }

        public int EspeciesID { get; set; }
        [ForeignKey("EspeciesID")]

        [ValidateNever]
        public Species Species { get; set; }


    }
}
