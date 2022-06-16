using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Turno
    {
        public int Id { get; set; }

        public int IdMedico { get; set; }

        public int IdPaciente { get; set; }

        public int IdEstado { get; set; }

        public DateTime FechaTurno { get; set; }

        public int HoraTurno { get; set; }

        public string Observaciones { get; set; }

        public string Diagnostico { get; set; }

        public bool Activo { get; set; }
    }
}
