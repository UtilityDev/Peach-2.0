using System;
using System.IO;

namespace Peach;

/*
** 'ProjectManager' class: responsible for handling everything related to projects created by the user.
*/
public static class ProjectManager
{
    // Interface for setting up projects
    public static void ProjectSetup()
    {
        string projectName      = ConsoleUtil.GetStringInput("Project Name");
        string projectLanguage  = ConsoleUtil.GetStringInput("Programming Language");
        string projectPath      = ConsoleUtil.GetStringInput("Project Path");

        CreateProject(projectName, projectLanguage, projectPath);
    }

    // Create a project with the specified name, programming language, and at the specified directory.
    public static void CreateProject(string projectName, string projectLanguage, string path)
    {
        // If the chosen language is valid
        if (PullExtension(projectLanguage) != "")
        {
            // If specified path exists, create a new project directory
            if (Directory.Exists(path))
            {
                // Create project directory inside given path
                string projectDirectory = Path.Combine(path, projectName);
                Directory.CreateDirectory(projectDirectory);

                // Create empty "main" file for given programming language
                CreateFile($"main.{PullExtension(projectLanguage)}", projectDirectory);

                ConsoleUtil.Log(ConsoleUtil.LogLevel.MESSAGE, "Project created!");
            }
            else // If path does not exist
            {
                ConsoleUtil.Log(ConsoleUtil.LogLevel.ERROR, "The specified directory does not exist!");
                ProjectSetup();
            }
        }
        // If the chosen language is NOT valid
        else
        {
            ConsoleUtil.Log(ConsoleUtil.LogLevel.ERROR, $"{projectLanguage} is not a valid language!");
            ProjectSetup();
        }
    }

    // Create a file at the specified path with optional content
    public static void CreateFile(string fileName, string path, string content = "")
    {
        // If path exists, create at given path
        if (Directory.Exists(path))
        {
            File.WriteAllText(Path.Combine(path, fileName), content);
        }
        else
        {
            ConsoleUtil.Log(ConsoleUtil.LogLevel.ERROR, "The specified directory does not exist.");
        }
    }

    // Return the file extension of the specified programming language.
    // In cases where the language does not exist or is in invalid in a way, return an empty string.
    public static string PullExtension(string language)
    {
        language = language.ToLower();
        switch (language)
        {
            case "c#":
                return "cs";
            case "c++":
                return "cpp";
            case "c":
                return "c";
            case "python":
                return "py";
            case "kotlin":
                return "kt";
            case "java":
                return "java";
            case "rust":
                return "rs";
            case "javascript":
                return "js";
            case "css":
                return "css";
            case "html":
                return "html";
            default:
                return "";
        }
    }
}