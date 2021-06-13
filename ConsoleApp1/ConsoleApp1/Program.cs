using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет, введи 1 или 2");
            int iNum = int.Parse(Console.ReadLine());
            if(iNum == 1)
            {
                Console.WriteLine("Ты ввел число 1");
                while (true)
                {
                    Console.Write(1);
                }
                
            }
            else
            {
                //помощь
            }
        }
    }
}
