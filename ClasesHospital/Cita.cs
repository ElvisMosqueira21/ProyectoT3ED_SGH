using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesHospital
{
    public class Cita
    {
        public int Codigo { get; set; }
        public Paciente Paciente { get; set; }
        public Medico Medico { get; set; }
        public DateTime Fecha { get; set; }

        public Cita()
        {

        }

        public Cita(int codigo, Paciente paciente, Medico medico, DateTime fecha)
        {
            Codigo = codigo;
            Paciente = paciente;
            Medico = medico;
            Fecha = fecha;
        }

        public override string ToString()
        {
            return $"{Fecha} - {Paciente.Nombre} - {Medico.Nombre}";
        }
    }
}
