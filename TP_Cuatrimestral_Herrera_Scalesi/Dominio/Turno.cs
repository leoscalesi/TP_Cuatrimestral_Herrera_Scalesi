using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Turno
    {
        public int id { get; set; }

        public int idMedico { get; set; }

        public int idPaciente { get; set; }

        public int idEstado { get; set; }

        public DateTime fechaTurno { get; set; }

        public int horaTurno { get; set; }

        public string observaciones { get; set; }

        public string diagnostico { get; set; }

        public bool activo { get; set; }
    }
}
