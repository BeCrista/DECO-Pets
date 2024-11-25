using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DECO_Pets.Models
{
    public class Seguradora
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string Designacao { get; set; }

        [Required]
        public int Qualidade { get; set; }

        [Required]
        public string QualidadeDesc { get; set; }

        [Required]
        public string Coberturas { get; set; }

        [Required]
        public string Destaque { get; set; }

        [Required]
        public string Observacoes { get; set; }

        public string? ImagemSeguradora { get; set; }

        [Required]
        public DateTime DateEdicao { get; set; }

        public string? Responsabilidade_Civil_LimiteAnual { get; set; }
        public string? Responsabilidade_Civil_Franquia { get; set; }

        public string? Despesas_Veterinarias_LimiteAnual { get; set; }
        public string? Despesas_Veterinarias_Franquia { get; set; }

        public string? Vacinas_LimiteAnual { get; set; }
        public string? Vacinas_Franquia { get; set; }

        public string? Cirurgia_LimiteAnual { get; set; }
        public string? Cirurgia_Franquia { get; set; }

        public string? Eutanasia_Funeral_LimiteAnual { get; set; }
        public string? Eutanasia_Funeral_Franquia { get; set; }

        public string? Desaparecimento_LimiteAnual { get; set; }
        public string? Desaparecimento_Franquia { get; set; }

        public string? Guarda_LimiteAnual { get; set; }
        public string? Guarda_Franquia { get; set; }

    }
}
