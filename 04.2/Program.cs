using System;

namespace _04._2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Player player = new Player();
            IPlayable player1 = player;
            IRecodable player2 = player;
            label:
            Console.WriteLine("Проиграть запись. Нажмите P");
            Console.WriteLine("Начать запись. Нажмите R");
            string key = Console.ReadLine();
            if (key == "P") 
            {
                Console.WriteLine("Пауза - P, Стоп - любая другая");
                player1.Play();
                while (true)
                {
                    switch (Console.ReadLine())
                    {
                        case "P":
                            player1.Pause();
                            Console.WriteLine("Возобновить просмотр - P");
                            if (Console.ReadLine() == "P")
                            {
                                player1.Play();
                            }                            
                            break;
                        default:
                            player1.Stop();
                            goto label;
                    }
                }
                
            }
            
            if (key == "R")
            {
                Console.WriteLine("Пауза - P, Стоп - любая другая");
                player2.Play();
                while (true)
                {
                    switch (Console.ReadLine())
                    {
                        case "P":
                            player2.Pause();
                            Console.WriteLine("Возобновить запись - P");
                            if (Console.ReadLine() == "P")
                            {
                                player2.Play();
                            }
                            break;
                        default:
                            player2.Stop();
                            goto label;
                    }
                }
            }
        }
    }
}
