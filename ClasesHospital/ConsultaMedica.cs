using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesHospital
{
    public class ConsultaMedica
    {
        public int CodigoConsulta { get; set; }
        public DateTime Fecha { get; set; }
        public string Diagnostico { get; set; }
        public string Tratamiento { get; set; }

        public ConsultaMedica(int codigoConsulta,
                              DateTime fecha,
                              string diagnostico,
                              string tratamiento)
        {
            CodigoConsulta = codigoConsulta;
            Fecha = fecha;
            Diagnostico = diagnostico;
            Tratamiento = tratamiento;
        }

        public override string ToString()
        {
            return $"Consulta: {CodigoConsulta} | Fecha: {Fecha.ToShortDateString()} | Diagnóstico: {Diagnostico} | Tratamiento: {Tratamiento}";
        }
    }
}
