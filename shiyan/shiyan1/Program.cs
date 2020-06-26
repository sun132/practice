using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shiyan1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] map = new int[4, 4]
            {
                { 0,2,2,4},
                { 2,0,2,4},
                { 0,4,2,0},
                { 2,8,0,2},
            };
            display(map);
            Console.ReadLine();
        }
        private static int[] RemoveZero(int[] array)
        {
            int[] newArray = new int[array.Length];
            int t = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != 0)
                {
                    newArray[t++] = array[i];
                }
            }
            return newArray;
        }
        private static void display(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
    }

