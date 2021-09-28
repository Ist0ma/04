using System;

namespace _04._2
{
    class Program
    {
        static void Main(string[] args)
        {            
            while (true)
            {
                Console.Write("\x000D     ");
                System.Threading.Thread.Sleep(200);
                Console.Write("\x000D.    ");
                System.Threading.Thread.Sleep(200);
                Console.Write("\x000D. .  ");
                System.Threading.Thread.Sleep(200);
                Console.Write("\x000D. . .");
                System.Threading.Thread.Sleep(200);
            }
        }
    }
}
