using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesHospital
{
    public class ColaEmergencias
    {
        private NodoEmergencia frente;

        public ColaEmergencias()
        {
            frente = null;
        }
        public void IngresarPaciente(Paciente paciente, int prioridad)
        {
            NodoEmergencia nuevo =
                new NodoEmergencia(paciente, prioridad);

            if (frente == null ||
                prioridad < frente.Prioridad)
            {
                nuevo.Sig = frente;
                frente = nuevo;
                return;
            }

            NodoEmergencia actual = frente;

            while (actual.Sig != null &&
                   actual.Sig.Prioridad <= prioridad)
            {
                actual = actual.Sig;
            }

            nuevo.Sig = actual.Sig;
            actual.Sig = nuevo;
        }
        public Paciente AtenderPaciente()
        {
            if (frente == null)
                return null;

            Paciente atendido = frente.Paciente;

            frente = frente.Sig;

            return atendido;
        }
        public void MostrarCola()
        {
            if (frente == null)
            {
                Console.WriteLine("No hay pacientes en emergencia.");
                return;
            }

            NodoEmergencia aux = frente;

            while (aux != null)
            {
                Console.WriteLine(
                    $"Paciente: {aux.Paciente.Nombre} | Prioridad: {aux.Prioridad}");

                aux = aux.Sig;
            }
        }
        public Paciente VerSiguiente()
        {
            if (frente == null)
                return null;

            return frente.Paciente;
        }

    }
}
