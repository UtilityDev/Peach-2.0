using System;

namespace Peach;

public static class ProjectManager
{
    public static void CreateProject(string projectName, string projectLanguage, string projectDirectory)
    {
        
    }

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