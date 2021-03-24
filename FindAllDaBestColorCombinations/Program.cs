using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindAllDaBestColorCombinations
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKey key = ConsoleKey.A;
            ConsoleColor background = ConsoleColor.Black;
            ConsoleColor foreground = ConsoleColor.White;

            while (key != ConsoleKey.Escape)
            {
                Console.ForegroundColor = foreground;
                Console.BackgroundColor = background;

                Console.Clear();

                Console.WriteLine($"The foreground color is {foreground.ToString()}");
                Console.WriteLine($"The background color is {background.ToString()}");

                Console.WriteLine("\nPress 'F' to cycle foreground color, 'B' to cycle background color, or 'Esc' to exit");

                key = Console.ReadKey().Key;

                if(key == ConsoleKey.F)
                {
                    foreground++;

                    if((int)foreground > 15)
                    {
                        foreground = ConsoleColor.Black;
                    }
                }
                else if (key == ConsoleKey.B)
                {
                    background++;

                    if ((int)background > 15)
                    {
                        background = ConsoleColor.Black;
                    }
                }
            }
        }
    }
}
