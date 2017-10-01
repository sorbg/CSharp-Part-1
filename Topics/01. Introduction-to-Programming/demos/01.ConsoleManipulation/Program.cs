using System;

class Program
{
    static void Main(string[] args)
    {
        Console.BackgroundColor = ConsoleColor.Cyan;
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WindowHeight = 30;
        Console.WindowWidth = 100;
        Console.WriteLine("Hello");
        Console.SetCursorPosition(15, 35);  // just a thought
        Console.WriteLine("Workshop!");
        Console.SetCursorPosition(10, 35);  // makes the result appear before Workshop
        int result = 3 / 1;
        Console.WriteLine(result);
        //Console.Clear();
    }
}

