using System;

namespace Peach;

public static class ConsoleUtil
{
    public static string GetStringInput(string msg)
    {
        msg = msg.ToUpper();
        Console.Write(msg + ": ");

        return Console.ReadLine();
    }
}