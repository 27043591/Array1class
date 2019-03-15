using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int arraylength = 1000;
            double[] array1 = new double[arraylength];
            Random RandomNum = new Random();
            int rows = 10;

            for (int i=0; i< arraylength; i++)
            {
                var nums = Math.Round(RandomNum.NextDouble() * 10, 3);
                array1[i] = nums;
            }

            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write("{0}", array1[i]);
                if ((i + 1)%rows == 0)
                {
                    Console.WriteLine();
                }
            }

            Console.Read();


            for(int i =0; i< arraylength; i++)
            {
                var nums =  Math.
            }
        }
    }
}
