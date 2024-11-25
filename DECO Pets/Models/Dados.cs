using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DECO_Pets.Models
{
    public class Dados
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public int SpeciesID { get; set; }
        [ForeignKey("SpeciesID")]

        [ValidateNever]
        public Species Species { get; set; }

        [Required]
        public int RaceID { get; set; }
        [ForeignKey("RaceID")]

        [ValidateNever]
        public Race Race { get; set; }

        public int? WeightID { get; set; }
        [ForeignKey("WeightID")]

        [ValidateNever]
        public Weight Weight { get; set; }

        [Required]
        public int AgeID { get; set; }
        [ForeignKey("AgeID")]

        [ValidateNever]
        public Age Age { get; set; }
    }
}
