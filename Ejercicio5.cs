using System;
using System.ComponentModel.DataAnnotations;
using System.Transactions;

namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nombre = new string[100];
            int i = 0;
            Console.WriteLine("Introdusca los nombres");
            do
            {
                nombre[i] = Console.ReadLine();
                if (nombre[i] == "")
                {
                    Console.WriteLine(nombre[i]);
                }
                
            }
            while (nombre[i] == "");
            Console.WriteLine("Los nombres escritos son:");
            Console.WriteLine(nombre[i]);
            
        }
    }
}
