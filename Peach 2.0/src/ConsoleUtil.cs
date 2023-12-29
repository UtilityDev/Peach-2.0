using System;

namespace Peach;

/*
** 'ConsoleUtil' class: simplifies the console. This class contains custom and simplified input and logging functionality.
*/
public static class ConsoleUtil
{
    public static string GetStringInput(string msg)
    {
        msg = msg.ToUpper();
        Console.Write(msg + ": ");

        return Console.ReadLine();
    }

    public enum LogLevel
    {
        MESSAGE,
        WARNING,
        ERROR,
    }
    public static void Log(LogLevel level, string msg)
    {
        switch (level)
        {
            case LogLevel.MESSAGE:
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(msg);
                Console.ResetColor();
                break;
            case LogLevel.WARNING:
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("WARNING: " + msg);
                Console.ResetColor();
                break;
            case LogLevel.ERROR:
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR: " + msg);
                Console.ResetColor();
                break;
            default:
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(msg);
                Console.ResetColor();
                break;
        }
    }
}