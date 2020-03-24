using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona lanzamiento;

            lanzamiento = new Persona();

            Console.WriteLine(lanzamiento.lanzar());
        }
    }

    class Persona
    {
        public int lanzar()
        {
            int randomInt;

            randomInt = new Random().Next(0, 3);

            return randomInt;
        }
    }
}
