using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // EjemploCsharp();

           
           //Declaración de objetos
            Persona persona = new Persona();
            persona.Nombres = "Hugo Felipe";
            persona.Apellidos = "Torrico Márquez";
            persona.Edad = 33;


            Persona persona2 = new Persona
            {
                Nombres = "Reyna Victoria",
                Apellidos = "Torrico Gamarra",
                Edad = 5
            };


            Console.WriteLine(persona.DevolverNombresCompletos());
            Console.WriteLine(persona2.DevolverNombresCompletos());

            Console.WriteLine("Hello Tecsup!");
            Console.Read();
        }

        static private void EjemploCsharp()
        {

            //TipoDato NombreVariable;
            //NombreVariable=valor;


            //Declaración de Variables
            int grado;
            grado = 3;

            int edad;
            edad = 33;

            string nombre;
            nombre = "Hugo Felipe";

            float sueldo;
            sueldo = 850.5f;

            bool esPeruano;
            esPeruano = true;

            char inicial;
            inicial = 't';

            //Condicionales

            if (edad > 18)
            {
                Console.WriteLine("Mayo de Edad");
            }

            if (esPeruano)
            {
                Console.WriteLine("Arriba Perú");
            }

            switch (grado)
            {
                case 1:
                    Console.WriteLine("Bienvenido a primer grado");

                    break;
                case 2:
                    Console.WriteLine("Bienvenido a segundo grado");

                    break;
                case 3:
                    Console.WriteLine("Bienvenido a tercer grado");

                    break;
                default:
                    break;
            }

            //Bucles

            int numero = 5;
            int resultado = 0;
            int multiplicador = 0;
            for (int i = 0; i < 12; i++)
            {
                multiplicador = i + 1;
                resultado = numero * multiplicador;
                Console.WriteLine(String.Concat(numero, " x ", multiplicador, "=", resultado));
            }
            int j = 0;
            while (resultado < 61)
            {
                j++;
                multiplicador = j + 1;
                resultado = numero * multiplicador;
                Console.WriteLine(String.Concat(numero, " x ", multiplicador, "=", resultado));

            }
        }
    }
}
