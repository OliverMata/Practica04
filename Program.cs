using System;

namespace Practica04
{
    class Program
    {
        private int[] media;

        public void cargar()
        {
            media = new int[4];

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Ingrese el numero:");
                media[i] = int.Parse(Console.ReadLine());
            }
        }


        public void mostrar()
        {
            int m = 0;
            for (int i = 0; i < 4; i++)
            {
                m +=media[1]/4;
                Console.WriteLine(" El numero ingresado es: {0}",media[1]);
            }
            Console.WriteLine("La media aritmetica es: {0}", m);
        }



        static void Main(string[] args)
        {
            //1. Un programa que pida al usuario 4 números, los memorice (utilizando un array), calcule su media aritmética y después muestre en pantalla la media y los datos tecleados.
            Program obj = new Program();
            obj.cargar();
            obj.mostrar();
        }
        }
    }
}
