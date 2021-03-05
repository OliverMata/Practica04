using System;

namespace Ejercicio_8
{
    class Program
    {
        //8. Crear un programa que defina un array de 5 elementos de tipo float que representen las alturas de 5 personas.
        //Obtener el promedio de las mismas. Contar cuántas personas son más altas que el promedio y cuántas más bajas.
        
      class Altura
        {

            private float[] altura;
            private float prom;

            public void alt()
            {
                altura = new float[5];
                for (int i = 0; i < 5; i++)
                {
                    Console.Write("Ingrese la altura: ");
                    string a = Console.ReadLine();
                    altura[i] = float.Parse(a);
                }
            }

            public void Promedio()
            {
                float suma;
                suma = 0;
                for (int j = 0; j < 5; j++)
                {
                    suma = suma + altura[j];
                }
                prom = suma / 5;
                Console.WriteLine("La altura promedio es: " + prom);
            }

            public void personas()
            {
                int mayores, menores, igual;
                mayores = 0;
                menores = 0;
                igual = 0;
                for (int p = 0; p < 5; p++)
                {
                    if (altura[p] > prom)
                    {
                        mayores++;
                    }
                    else
                    {
                        if (altura[p] < prom)
                        {
                            menores++;
                        }
                        else
                        {
                            if (altura[p] == prom)
                            {
                                igual++;
                            }
                        }
                    }
                }
                Console.WriteLine("La cantidad de personas mayores al promedio de altura es de " + mayores + " personas");
                Console.WriteLine("La cantidad de personas menores al promedio de altura es de " + menores + " personas");
                Console.WriteLine("La cantidad de personas que es igual al promedio de altura es de " + igual + " personas");
                Console.ReadKey();
            }

            static void Main(string[] args)
            {
                Altura obj = new Altura();
                obj.alt();
                obj.Promedio();
                obj.personas();
            }
        }
        
    }
}
