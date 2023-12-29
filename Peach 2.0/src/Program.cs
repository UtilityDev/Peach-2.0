using System;

namespace Peach;

public class Program
{
    public static void Main()
    {
        string projectName = ConsoleUtil.GetStringInput("Project Name");
        string projectLanguage = ConsoleUtil.GetStringInput("Programming Language").ToLower();
        string projectDirectory = ConsoleUtil.GetStringInput("Project Directory");
        string extension = ProjectManager.PullExtension(projectLanguage);

        ProjectManager.CreateProject(projectName, projectLanguage, projectDirectory);
    }
}