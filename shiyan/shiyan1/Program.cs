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
            Console.WriteLine();
            map = wipeDown(map);
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
        
        private static int[] merge(int[] array)
        {
            array = RemoveZero(array);
            for (int i = 0; i < array.Length-1; i++)
            {
                if (array[i] == array[i + 1] && array[i] != 0) 
                {
                    array[i] += array[i];
                    array[i + 1] = 0;
                }
            }
            array = RemoveZero(array);
            return array;
        }
        private static int[,] wipeUp(int[,] map)
        {
            int[] middle = new int[map.GetLength(0)];
            for (int r = 0; r < map.GetLength(1); r++)
            {
                for (int i = 0; i < map.GetLength(0); i++)
                {
                    middle[i] = map[i, r];
                }
                middle = merge(middle);
                for (int i = 0; i < map.GetLength(0); i++)
                {
                    map[i, r] = middle[i];
                }
            }
            return map;
            
        }
        private static int[,] wipeDown(int[,] map)
        {
            int[] middle = new int[map.GetLength(0)];
            for (int r = 0; r < map.GetLength(1); r++)
            {
                for (int i = map.GetLength(0) - 1; i >= 0; i--)
                {
                    middle[map.GetLength(0) - 1 - i] = map[i, r];
                }
                middle = merge(middle);
                for (int i = map.GetLength(0) - 1; i >= 0; i--)
                {
                    map[i, r] = middle[map.GetLength(0) - 1 - i];
                }
            }
            return map;

        }
    }
}

