using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DECO_Pets.Models
{
    public class Premios
    {
        [Key]
        public int ID { get; set; }

        public int DadosID { get; set; }
        [ForeignKey("DadosID")]

        [ValidateNever]
        public Dados Dados { get; set; }

        public int SeguradoraID { get; set; }
        [ForeignKey("SeguradoraID")]

        [ValidateNever]
        public Seguradora Seguradora { get; set; }

        [Required]
        public int Premio { get; set; }
    }
}
