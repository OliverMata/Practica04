using System;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Un programa que pida al usuario 10 números y luego calcule y muestre.
            int[] aNumeros  = new int[10];

            for (int X = 0; X < 10; X++)
            {
                Console.WriteLine("Introduzca un numero: ");
                aNumeros[X] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Los numeros organizados son estos: {0}",i);
            }
        }
    }
}
