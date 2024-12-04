using System;
using System.Diagnostics.CodeAnalysis;

namespace Methods_perameters
{
    internal class Program
    {
        static void Main()
        {
            //int i = 0;
            //demo(ref i);
            //Console.WriteLine(i);

            //int total = 0;
            //int product = 0;
            //calculator(10, 20, out total, out product);
            //Console.WriteLine("sum: {0} \npeoduct: {1}", total, product);

            int[] number = new int[3];

            number[0] = 1;
            number[1] = 2;
            number[2] = 3;
            // paramsMethod();
            paramsMethod(number);
        }
        //public static void demo(ref int j)
        //{
        //    j = 101;
        
        //}
        //public static void calculator(int fn, int sn, out int sum, out int product)
        //{
        //    sum = fn + sn;
        //    product = fn * sn;

        //}
        public static void paramsMethod (params int[] number)
        {
            Console.WriteLine("there are {0} elements", number.Length);
            foreach(int i in number)
            {
                Console.WriteLine(i);
            }
        }
    }
}
