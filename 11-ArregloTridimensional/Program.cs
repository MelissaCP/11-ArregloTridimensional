using System;
using C = System.Console;

namespace _11_ArregloTridimensional
{
    class Program
    {
        static void Main(string[] args)
        {
            /// Practica 11
            /// 11.Crear un arreglo tridimensional obtener la suma de sus elementos.
            /// 
            /// Chávez Pérez Melissa
            /// #M21210035
            C.BackgroundColor = ConsoleColor.Blue;
            C.ForegroundColor = ConsoleColor.White;

            int[] array1 = new int[2];

            int[,] mn = new int[3, 3] { { 4, 9, 2 }, { 3, 5, 7 }, { 8, 1, 6 } };

            int[,] array2 = new int[2, 2];

            int[,,] array3 = new int[2, 2, 2];

            int[,,,] array4 = new int[2, 2, 2, 2];

           // int suma = 0;

            C.WriteLine("Arreglo 1 {0}", array1.Rank);

            C.WriteLine("Arreglo 2 {0}", array2.Rank);

            C.WriteLine("Arreglo 3 {0}", array3.Rank);

            C.WriteLine("Arreglo 4 {0}", array4.Rank);

            //SUMA DE LINEAS
            for (int i = 0; i < mn.GetLength(0); i++)
            {
                int suma = 0;
                for (int j = 0; j < mn.GetLength(1); j++)
                {
                    suma += mn[i, j];
                }
                Console.WriteLine("Linea " + i + " = " + suma);
            }
            //SUMA DE COLUMNAS

            for (int j = 0; j < array3.GetLength(0); j++)
            {
                int suma = 0;
                for (int i = 0; i < array3.GetLength(1); i++)
                {
                    suma += mn[i, j];
                }
                Console.WriteLine("Columna " + j + " = " + suma);
            }
            //SUMA DE DIAGONAL \
            int sumad1 = 0;
            for (int i = 0; i < mn.GetLength(0); i++)
            {
                for (int j = i; j <= i; j++)
                {
                    sumad1 += mn[i, j];
                }

            }
            Console.WriteLine("Linea diagonal \\ = " + sumad1);
            //SUMA DE DIAGONAL /
            int sumad2 = 0;
            for (int j = 0; j < array1.GetLength(0); j++)
            {
                for (int i = mn.GetLength(0) - j - 1; i == array1.GetLength(0) - j - 1; i++)
                {
                    sumad2 += mn[i, j];
                }

            }
            C.ReadLine();
            C.WriteLine("Linea diagonal / = " + sumad2);

        }
    }

}