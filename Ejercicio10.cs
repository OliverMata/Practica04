using System;

namespace Ejercicio_10
{
    class Program
    {  //Confeccionar una clase que permita carga el nombre y la edad de una persona.Mostrar los datos cargados.
        //Imprimir un mensaje si es mayor de edad (edad>=18).
        class Persona
        {
            private string nombre;
            private int edad;

            public void Personas()
            {
                Console.WriteLine();
                Console.Write("Ingrese el nombre: ");
                nombre = Console.ReadLine();
                string m;
                Console.Write("Ingrese la edad: ");
                m = Console.ReadLine();
                edad = int.Parse(m);
            }

            public void Imprimir()
            {
               Console.Write("Nombre: ");
               Console.WriteLine(nombre);
               Console.Write("Edad: ");
               Console.WriteLine(edad);
            }

            public void Mayor()
            {
               if (edad >= 18)
               {
                   Console.Write("Es mayor de edad");
               }
               else
               {
                  Console.Write("No es mayor de edad");
                 
               }
               
               Console.ReadKey();
               Console.WriteLine();
            }


            static void Main(string[] args)
            {
               Persona obj = new Persona();
               obj.Personas();
               obj.Imprimir();
               obj.Mayor();
            }
        }
        
    }
}
