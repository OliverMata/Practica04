using System;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Un programa que pida al usuario 10 números y luego calcule y muestre.
            int[] aNumeros  = new int[10];
            int m = aNumeros[0];
            Console.WriteLine("Introduzca un numero: ");

            for (int X = 0; X < 9; X++)
            {
                
                aNumeros[X] = int.Parse(Console.ReadLine());
            }

            Console.Clear();
            for (int i = 0; i < 9; i++)
            {
                if (aNumeros[i] > m)
                {
                    m = aNumeros[i];
                }
                
            }
            Console.WriteLine();
            Console.WriteLine("El numero mas grande es: " + m);
            Console.WriteLine();
        }
    }
}
