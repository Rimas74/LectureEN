using System;

namespace ConsoleApp1
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            //Task_1
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("    /\\    ");
            Console.WriteLine("   /  \\   ");
            Console.WriteLine("  /    \\  ");
            Console.WriteLine(" /______\\ ");
            Console.WriteLine();
            Console.WriteLine(new string('-', 20));

            //Task_2
            Console.WriteLine(new string(' ',5) + new string('*',5));
            Console.WriteLine(new string(' ',3) + new string('*',2)+ new string(' ', 5)+ new string('*', 2));
            Console.WriteLine(new string(' ',1) + new string('*',2)+ new string(' ', 9)+ new string('*', 2));
            Console.WriteLine(new string(' ',0) + new string('*',2)+ new string(' ', 3)+"Hello" + new string(' ', 3) + new string('*', 2));
            Console.WriteLine(new string(' ',0) + new string('*',2)+ new string(' ', 4)+ "from"+ new string(' ', 3)+new string('*', 2));
            Console.WriteLine(new string(' ',1) + new string('*',2)+ new string(' ', 3)+"C#" + new string(' ', 4) + new string('*', 2));
            Console.WriteLine(new string(' ',3) + new string('*',2)+ new string(' ', 5)+ new string('*', 2));
            Console.WriteLine(new string(' ',5) + new string('*', 5));
            Console.WriteLine(new string('-', 20));

            //Task_3

            
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("    /\\    ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("   /  \\   ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("  /    \\  ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(" /______\\ ");
            Console.WriteLine();
            Console.WriteLine(new string('-', 20));

            //Task_4
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("  / \\     / \\");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(" /   \\   /   \\");
            Console.ResetColor();
            Console.WriteLine(" \\    \\ /    /");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("  \\         / ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("   \\       /  ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("    \\     /");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("     \\   /");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("      \\ /");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("       v");
            Console.WriteLine("  ");
        
            Console.WriteLine();
            }
        }
    }
