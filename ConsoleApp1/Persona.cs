using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Persona
    {
        //Escribir prop y luego tap 2 veces

        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public int Edad { get; set; }

        public int Nota1 { get; set; }
        public int Nota2 { get; set; }
        public int Nota3 { get; set; }


        public string DevolverNombresCompletos()
        {
            string resultado = Nombres + " " + Apellidos;
            return resultado;
        }

        //Crear una función que me retorne si es mayor de edad o menor de edad


        //Crear otro función que retorne el promedio de las 3 notas.


    }
}
