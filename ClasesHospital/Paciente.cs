using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ClasesHospital
{
    public class Paciente
    {
        //Atributos
        public int Codigo {  get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string DNI { get; set; }
        public string Telefono { get; set; }
        public string Sexo { get; set; } 
        //Constructor vacio
        public Paciente() 
        {

        }
        //Constructor con parametros
        public Paciente(int codigo, string nombre, int edad, string dni, string telefono, string sexo) 
        {
            Codigo = codigo;
            Nombre = nombre;
            Edad = edad;
            DNI = dni;
            Telefono = telefono;
            Sexo = sexo;
        }
        // Método para mostrar información
        public override string ToString()
        {
            return $"{Codigo} - {Nombre} - {DNI} - {Sexo}";
        }

    }
}
