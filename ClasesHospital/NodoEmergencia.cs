using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesHospital
{
    public class NodoEmergencia
    {
        public Paciente Paciente { get; set; }
        public int Prioridad { get; set; }
        public NodoEmergencia Sig { get; set; }

        public NodoEmergencia(Paciente paciente, int prioridad)
        {
            Paciente = paciente;
            Prioridad = prioridad;
            Sig = null;
        }
    }
}
