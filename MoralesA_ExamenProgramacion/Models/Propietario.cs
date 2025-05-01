using System.ComponentModel.DataAnnotations;

namespace MoralesA_ExamenProgramacion.Models
{
    public class Propietario
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }
        [Range(1,120)]
        public int Edad { get; set; }
        [DataType(DataType.Currency)]
        public decimal SaldoCuenta { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public bool TieneMembresia { get; set; }
        [DataType(DataType.Date)]
        public DateTime FechadeRegistro { get; set; }
    }
}
