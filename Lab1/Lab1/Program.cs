using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona datoPersona;

            datoPersona = new Persona("Bob", "Kunga");

            Console.WriteLine(datoPersona.Lanzar());
        }
    }

    class Persona
    {
        String nombrePersona;

        String apellidoPersona;

        public int Lanzar()
        {
            int numeroAzar;

            numeroAzar = new Random().Next(0, 3);

            return numeroAzar;
        }

        public Persona(string nombre, string apellido)
        {
            nombrePersona = nombre;

            apellidoPersona = apellido;

            Console.WriteLine(nombrePersona + " " + apellidoPersona);
        }
    }
}
