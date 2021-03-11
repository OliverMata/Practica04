using System;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2.Un programa que pida al usuario 5 números reales (pista: necesitarás un array de "float") y luego los muestre en el orden contrario al que se introdujeron
            float[] aNumero = new float[5];
            Console.WriteLine("Introduzca los numeros: ");
            for (int i = 0; i < 5; i++)
            {
                aNumero[i] = float.Parse(Console.ReadLine());
               
            }
            Array.Sort(aNumero);
            Array.Reverse(aNumero);
            Console.Clear();
            
            foreach (float i in aNumero)
            {
                Console.WriteLine(i);
            }



            Console.ReadKey();   
        }
    }
}
