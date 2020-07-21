using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ball
{
    class Program
    {
        static void Main(string[] args)
        {
            Size boal01 = new Size("01", 10);
            Size boal02 = new Size();
            boal02.Name = "02";
            boal02.Diameter = 39;
            Size[] boalArray = new Size[5];
            boalArray[0] = boal01;
            boalArray[1] = boal02;
            boalArray[2] = new Size("03",53);
            boalArray[3] = new Size("04", 5);
            boalArray[4] = new Size("05", 92);
            Size result = Small(boalArray);
            Console.WriteLine(result.Name);
            Console.ReadLine();

        }
        private static Size Small(Size[] array)
        {
            int number = 0;
            for (int i = 0; i < array.Length; i++)
            {
                int smaller = array[0].Diameter;
                
                if (smaller >= array[i].Diameter) 
                {
                    smaller = array[i].Diameter;
                    number = i;
                }
            }
            return array[number];
        }
    }
}
