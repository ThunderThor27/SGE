using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGE.Models
{
    [Table("Etapas")]
    public class Etapas
    {
        [Column("Id")]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Column("titulo")]
        [Display(Name = "Etapa")]
        public string Titulo { get; set; } = string.Empty;

        [Column("ano")]
        [Display(Name = "Ano da Etapa")]
        public int Ano { get; set; }
    }
}
