using System;

namespace AbsoluteValuesSumMinimization
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AbsoluteValuesSumMinimization(new int[] { 2, 4, 7 }));
            Console.WriteLine(absoluteValuesSumMinimization(new int[] { 2, 4, 7, 6 }));
            Console.WriteLine(absoluteValuesSumMinimization(new int[] { 2, 4, 7, 6, 6 }));
            Console.WriteLine(absoluteValuesSumMinimization(new int[] { 2, 4, 7, 6, 6, 8 }));
        }

        public static int AbsoluteValuesSumMinimization(int[] a)
        {
            return new int[] { 0 };
        }
    }
}


