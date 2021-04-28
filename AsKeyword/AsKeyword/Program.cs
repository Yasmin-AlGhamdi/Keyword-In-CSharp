using System;

namespace AsKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            object value = 1;
            string anotherValue = value as string;

            Console.WriteLine(anotherValue);



            object[] o = new object[5];
            o[0] = "hi";
            o[1] = 1;
            o[2] = "Hello";
            o[3] = 534.0;
            o[4] = null;

            for(int i=0; i<o.Length; i++)
            {
                string str = o[i] as string;

                if(str !=null)
                {
                    Console.WriteLine(" ' " + str + " ' ");
                }
                else
                {
                    Console.WriteLine("Not a string.");
                }
            }


            Console.ReadKey();
        }
    }
}
