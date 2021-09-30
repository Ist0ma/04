using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._2
{
    public class Player : IPlayable, IRecodable
    {
        void IPlayable.Play()
        {
            Console.WriteLine("Просмотр...");
        }

        void IRecodable.Play()
        {
            Console.WriteLine("Идет запись...");
        }

        void IPlayable.Pause()
        {
            Console.WriteLine("Просмотр на паузе");
        }
        void IRecodable.Pause()
        {
            Console.WriteLine("Запись преостановленна");
        }

        void IPlayable.Stop()
        {
            Console.WriteLine("Просмотр стоп");
        }

        void IRecodable.Stop()
        {
            Console.WriteLine("Запись стоп");
        }
    }
}
