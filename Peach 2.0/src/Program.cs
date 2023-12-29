using System;

namespace Peach;

/*
** 'Program' class: Program entry point. 
** Even though it may make more sense to write a method inside 'ProjectManager' that handles what this class does,
** I decided to just write it in here anyways. 'ProjectManager' is bloated enough as it is, anyways.
** Also, this code sucks ass. Please, someone, make it look pretty.
*/
public class Program
{
    public static void Main()
    {
        string projectChoice;

        // Continuously ask user for project type until the criteria is met
        do
        {
            ConsoleUtil.Log(ConsoleUtil.LogLevel.MESSAGE, "Would you like to create a typical or a web development project? :)");
            projectChoice = ConsoleUtil.GetStringInput("Choice").ToLower().Trim();
            
            if (projectChoice == "web")
                ProjectManager.ProjectSetup(true);
            else if (projectChoice == "typical")
                ProjectManager.ProjectSetup(false);
        }
        while ((projectChoice != "web") && (projectChoice != "typical"));
    }
}