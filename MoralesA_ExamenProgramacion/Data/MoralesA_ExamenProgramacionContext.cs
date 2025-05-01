using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MoralesA_ExamenProgramacion.Models;

namespace MoralesA_ExamenProgramacion.Data
{
    public class MoralesA_ExamenProgramacionContext : DbContext
    {
        public MoralesA_ExamenProgramacionContext (DbContextOptions<MoralesA_ExamenProgramacionContext> options)
            : base(options)
        {
        }

        public DbSet<MoralesA_ExamenProgramacion.Models.Propietario> Propietario { get; set; } = default!;
        public DbSet<MoralesA_ExamenProgramacion.Models.Mascota> Mascota { get; set; } = default!;
        public DbSet<MoralesA_ExamenProgramacion.Models.Visita> Visita { get; set; } = default!;
    }
}
