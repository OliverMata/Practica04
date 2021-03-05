using System;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2.Un programa que pida al usuario 5 números reales (pista: necesitarás un array de "float") y luego los muestre en el orden contrario al que se introdujeron
            double[] aNumero;
            aNumero = new double[5];
            
            Array.Reverse(aNumero);
            Array.Sort(aNumero);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Introduzca los numeros: ");
                aNumero[i] = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(aNumero[i]);
            }
            
        }
    }
}
