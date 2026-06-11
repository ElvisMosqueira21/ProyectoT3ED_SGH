using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesHospital
{
    public class Medico
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Especialidad { get; set; }

        public Medico()
        {

        }

        public Medico(int codigo, string nombre, string especialidad)
        {
            Codigo = codigo;
            Nombre = nombre;
            Especialidad = especialidad;
        }

        public override string ToString()
        {
            return $"{Nombre} - {Especialidad}";
        }
    }
}
