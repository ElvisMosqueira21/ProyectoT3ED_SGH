using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesHospital
{
    public class NodoConsulta
    {
        public ConsultaMedica Datos { get; set; }
        public NodoConsulta Sig { get; set; }

        public NodoConsulta(ConsultaMedica consulta)
        {
            Datos = consulta;
            Sig = null;
        }
    }
}
