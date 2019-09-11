using System;

namespace class21
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("How many years of professional experinece?");
            int var = int.Parse(Console.ReadLine());
            for (int i = 0; i < var; i++)
            {
                Console.WriteLine("you have {0} years of experience",i);
            }
        }
    }
}
