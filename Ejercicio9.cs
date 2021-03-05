using System;

namespace Ejercicio_9
{
    class Program
    {
        //9. Crear una clase que permita ingresar valores enteros por teclado y nos muestre la tabla de multiplicar de dicho valor. Finalizar el programa al ingresar el -1.
        
        class TablaMultiplicar
        {
            public void Multiplicar()
            {
                int numero;
                string s;
                do
                {
                    Console.WriteLine();
                    Console.Write("Ingrese un numero: ");
                    s = Console.ReadLine();
                    numero = int.Parse(s);
                    Console.WriteLine();
                    if (numero != -1)
                    {
                        Calcular(numero);
                    }
                } while (numero != -1);
            }

            public void Calcular(int v)
            {
                int m = 1;
                for (int i = v; i <= v * 12; i = i + v)
                {
                    Console.WriteLine(v +" * "+ (m++) + " = "+ i);
                }
                Console.WriteLine();
                Console.WriteLine("Inserte '-1' si quiere salir");
                Console.WriteLine();
            }

            static void Main(string[] args)
            {
                TablaMultiplicar obj = new TablaMultiplicar();
                obj.Multiplicar();
            }
        }
    }    
}