using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesHospital
{
    public class NodoMedico
    {
        public Medico Datos { get; set; }

        public NodoMedico Izq { get; set; }

        public NodoMedico Der { get; set; }

        public NodoMedico(Medico medico)
        {
            Datos = medico;
            Izq = null;
            Der = null;
        }
    }
}
