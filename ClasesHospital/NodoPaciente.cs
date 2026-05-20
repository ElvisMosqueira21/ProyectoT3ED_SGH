using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesHospital
{
    public class NodoPaciente
    {
        // Guarda el objeto paciente
        public Paciente Datos { get; set; }

        // Referencia al siguiente nodo
        public NodoPaciente Sig { get; set; }

        // Constructor
        public NodoPaciente(Paciente paciente)
        {
            Datos = paciente;
            Sig = null;
        }
    }
}
