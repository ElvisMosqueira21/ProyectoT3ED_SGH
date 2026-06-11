using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesHospital
{
    public class ConsultaMedica
    {
        public DateTime Fecha { get; set; }
        public string Diagnostico { get; set; }
        public string Tratamiento { get; set; }

        public ConsultaMedica(DateTime fecha,string diagnostico, string tratamiento)
        {
            Fecha = fecha;
            Diagnostico = diagnostico;
            Tratamiento = tratamiento;
        }
    }
}
