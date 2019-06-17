using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Media;

namespace tamagotchi
{
    class Program
    {
        static void Main(string[] args)
        {
            int status = 0;
            do
            {
                Console.WriteLine("(.)");
                Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine("(:)");
                Thread.Sleep(1000);
                Console.Clear();
                status = status + 1;
            } while (status < 10);

            int blitz = 10;
            do
            {
                Console.BackgroundColor = ConsoleColor.White;
                Thread.Sleep(100);
                Console.BackgroundColor = ConsoleColor.Black;
                Thread.Sleep(100);
            } while (blitz < 10);

            Console.WriteLine("Das Tamagotchi ist ausgeschlüpft!");
            Console.ReadKey();
            do
            {
            Console.WriteLine("(*-*)");
                Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine(" (*o*)");
                Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine("  (*-*)");
                Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine("   (*o*)");
                Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine("  (*-*)");
                Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine(" (*o*)");
                Thread.Sleep(1000);
                Console.Clear();
                status = status + 1;
        } while (status < 20);
            Console.ReadKey();

        }
    }
}
