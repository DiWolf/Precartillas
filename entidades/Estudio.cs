using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace entidades
{
    public class Estudio
    {
        [Key]
        [ReadOnly(true)]
        public int Id { get; set; }

        [Column("Grado")]
        [Required]
        [DisplayName("Grado de Estudio")]
        [MaxLength(100)]
        public string Grado { get; set; }
        [Column("Descripcion")]
        [DisplayName("Descripción")]
        [MaxLength(200)]
        public string Descripcion { get; set; }
    }
}
