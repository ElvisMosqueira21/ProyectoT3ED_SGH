using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesHospital
{
    public class HistorialClinico
    {
        private NodoConsulta cabeza;

        public HistorialClinico()
        {
            cabeza = null;
        }
        public void AgregarConsulta(ConsultaMedica consulta)
        {
            NodoConsulta nuevo = new NodoConsulta(consulta);

            if (cabeza == null)
            {
                cabeza = nuevo;
                return;
            }

            NodoConsulta aux = cabeza;

            while (aux.Sig != null)
            {
                aux = aux.Sig;
            }

            aux.Sig = nuevo;
        }
        public void MostrarHistorial()
        {
            if (cabeza == null)
            {
                Console.WriteLine("No existen consultas registradas.");
                return;
            }

            NodoConsulta aux = cabeza;

            while (aux != null)
            {
                Console.WriteLine(aux.Datos);
                aux = aux.Sig;
            }
        }
        public ConsultaMedica BuscarConsulta(int codigoConsulta)
        {
            NodoConsulta aux = cabeza;

            while (aux != null)
            {
                if (aux.Datos.CodigoConsulta == codigoConsulta)
                {
                    return aux.Datos;
                }

                aux = aux.Sig;
            }

            return null;
        }
        public bool EliminarConsulta(int codigoConsulta)
        {
            if (cabeza == null)
                return false;

            if (cabeza.Datos.CodigoConsulta == codigoConsulta)
            {
                cabeza = cabeza.Sig;
                return true;
            }

            NodoConsulta actual = cabeza;

            while (actual.Sig != null)
            {
                if (actual.Sig.Datos.CodigoConsulta == codigoConsulta)
                {
                    actual.Sig = actual.Sig.Sig;
                    return true;
                }

                actual = actual.Sig;
            }

            return false;
        }
    }
}
