using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesHospital
{
    public class ListaCitas
    {
        private NodoCita cabeza;

        public ListaCitas()
        {
            cabeza = null;
        }
        public void AgregarCita(Cita cita)
        {
            NodoCita nuevo = new NodoCita(cita);

            if (cabeza == null)
            {
                cabeza = nuevo;
                return;
            }

            NodoCita aux = cabeza;

            while (aux.Sig != null)
            {
                aux = aux.Sig;
            }

            aux.Sig = nuevo;
        }
        public Cita BuscarCita(int idCita)
        {
            NodoCita aux = cabeza;

            while (aux != null)
            {
                if (aux.Datos.CodigoCita == idCita)
                {
                    return aux.Datos;
                }

                aux = aux.Sig;
            }

            return null;
        }
        public void MostrarCitas()
        {
            if (cabeza == null)
            {
                Console.WriteLine("No hay citas registradas.");
                return;
            }

            NodoCita aux = cabeza;

            while (aux != null)
            {
                Console.WriteLine(aux.Datos);
                aux = aux.Sig;
            }
        }
        public bool EliminarCita(int idCita)
        {
            if (cabeza == null)
                return false;

            if (cabeza.Datos.CodigoCita == idCita)
            {
                cabeza = cabeza.Sig;
                return true;
            }

            NodoCita actual = cabeza;

            while (actual.Sig != null)
            {
                if (actual.Sig.Datos.CodigoCita == idCita)
                {
                    actual.Sig = actual.Sig.Sig;
                    return true;
                }

                actual = actual.Sig;
            }

            return false;
        }
        public bool ExisteConflicto(Medico medico, DateTime fechaHora)
        {
            NodoCita aux = cabeza;

            while (aux != null)
            {
                if (aux.Datos.Medico.Codigo == medico.Codigo &&
                    aux.Datos.FechaHora == fechaHora)
                {
                    return true;
                }

                aux = aux.Sig;
            }

            return false;
        }
    }
}

