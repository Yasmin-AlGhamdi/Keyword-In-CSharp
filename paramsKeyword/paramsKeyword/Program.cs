using System;

namespace paramsKeyword
{
    class Program
    {
        public static void UseParams(params int[] list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine();
        }
        public static void UseParams2(params object[] list)
        {
            for(int i=0; i< list.Length; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            UseParams(1, 2, 3, 4, 5, 6);

            UseParams2(1, 'a', "test");

            int[] myIntArray = { 5, 6, 7, 8, 9 };
            UseParams(myIntArray);

            Console.ReadKey();
        }
    }
}
