using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesHospital
{
    public class ArbolMedicos
    {
        private NodoMedico raiz;

        public ArbolMedicos()
        {
            raiz = null;
        }
        public void Insertar(Medico medico)
        {
            raiz = InsertarRecursivo(raiz, medico);
        }

        private NodoMedico InsertarRecursivo(NodoMedico nodo, Medico medico)
        {
            if (nodo == null)
                return new NodoMedico(medico);

            if (medico.Codigo < nodo.Datos.Codigo)
                nodo.Izq = InsertarRecursivo(nodo.Izq, medico);

            else if (medico.Codigo > nodo.Datos.Codigo)
                nodo.Der = InsertarRecursivo(nodo.Der, medico);

            return nodo;
        }
        //buscar medico por codigo
        public Medico Buscar(int codigo)
        {
            NodoMedico actual = raiz;

            while (actual != null)
            {
                if (codigo == actual.Datos.Codigo)
                    return actual.Datos;

                if (codigo < actual.Datos.Codigo)
                    actual = actual.Izq;
                else
                    actual = actual.Der;
            }

            return null;
        }
        //Buscar inorden
        public void MostrarInOrden()
        {
            MostrarInOrdenRec(raiz);
        }

        private void MostrarInOrdenRec(NodoMedico nodo)
        {
            if (nodo != null)
            {
                MostrarInOrdenRec(nodo.Izq);

                Console.WriteLine(nodo.Datos);

                MostrarInOrdenRec(nodo.Der);
            }
        }
    }

}
