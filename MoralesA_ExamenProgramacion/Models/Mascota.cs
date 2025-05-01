using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoralesA_ExamenProgramacion.Models
{
    public class Mascota
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Raza { get; set; }
        public int Edad { get; set; }
        public string Color { get; set; }
        public string Tipo { get; set; }
        public int PropietarioId { get; set; }
        [ForeignKey("PropietarioId")]
        public Propietario? Propietario { get; set; }
    }
}
