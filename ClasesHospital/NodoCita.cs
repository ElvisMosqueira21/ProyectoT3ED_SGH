using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesHospital
{
    public class NodoCita
    {
        public Cita Datos { get; set; }
        public NodoCita Sig { get; set; }

        public NodoCita(Cita cita)
        {
            Datos = cita;
            Sig = null;
        }
    }
}
