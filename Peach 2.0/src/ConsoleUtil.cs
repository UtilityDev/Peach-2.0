using System;

namespace Peach;

/*
** 'ConsoleUtil' class: simplifies the console. This class contains custom and simplified input and logging functionality.
*/
public static class ConsoleUtil
{
    public enum LogLevel
    {
        MESSAGE,
        WARNING,
        ERROR,
    }

    public static string GetStringInput(string msg)
    {
        msg = msg.ToUpper();
        Console.Write(msg + ": ");

        return Console.ReadLine();
    }

    public static void Log(LogLevel level, string msg)
    {
        switch (level)
        {
            case LogLevel.MESSAGE:
                Console.WriteLine("MESSAGE: " + msg);
                break;
            case LogLevel.WARNING:
                Console.WriteLine("WARNING: " + msg);
                break;
            case LogLevel.ERROR:
                Console.WriteLine("ERROR: " + msg);
                break;
            default:
                Console.WriteLine("MESSAGE: " + msg);
                break;
        }
    }
}