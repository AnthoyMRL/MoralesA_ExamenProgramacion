using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoralesA_ExamenProgramacion.Models
{
    public class Visita
    {
        [Key]
        public int Id { get; set; }

        [DataType(DataType.Date)]
        public DateTime FechaVisita { get; set; }

        public decimal Tarifa { get; set; }

        public string Motivo {
            get {
                    if(Tarifa<= 0)
                    {
                        return "Consulta";
                    }
                    else if (Tarifa > 0 && Tarifa <= 30)
                    {
                        return "Vacunación";
                    }
                    else if (Tarifa > 30 && Tarifa <= 20)
                    {
                        return "Revisión";
                    }
                    else
                    {
                        return "Cirugía";
                    }
                }
                               } // Vacunación, Revisión, Cirugía

        public bool RequiereMedicacion { get; set; }

        public int MascotaId { get; set; }
        [ForeignKey("MascotaId")]
        public Mascota? Mascota { get; set; }
    }
}
