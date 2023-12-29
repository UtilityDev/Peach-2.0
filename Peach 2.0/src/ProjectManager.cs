using System;
using System.IO;

namespace Peach;

/*
** 'ProjectManager' class: responsible for handling everything related to projects created by the user.
*/
public static class ProjectManager
{
    // Create a project with the specified name, programming language, and at the specified directory.
    public static void CreateProject(string projectName, string projectLanguage, string path)
    {
        // If specified path exists, create a new project directory
        if (Path.Exists(path))
        {
            // Create project directory inside given path
            string projectDirectory = Path.Combine(path, projectName);
            Directory.CreateDirectory(projectDirectory);

            // Create empty "main" file for given programming language
            File.WriteAllText(Path.Combine(projectDirectory, $"main.{PullExtension(projectLanguage)}"), "");
            
            ConsoleUtil.Log(ConsoleUtil.LogLevel.MESSAGE, "Project created!");
        } else // If path does not exist
        {
            ConsoleUtil.Log(ConsoleUtil.LogLevel.ERROR, "The specified directory does not exist!");
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