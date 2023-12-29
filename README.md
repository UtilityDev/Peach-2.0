# peach 2.0 🍑

## What is it?
Peach is a CLI application that automatically sets up programming projects for you! You can make `typical` projects (literally everything not web related) or `web` projects. You give it a name, a language, and a directory, and peach sets everything up for you. Even though it is **VERY** basic in its current state, you can always make a pull request and add new features 😉

Peach was originally written in Python in 2022 (https://github.com/UtilityDev/peach/tree/master), but I felt very limited by Python and the project became a total mess (even messier than this). Even though this project is simple in its current state, I still hope it can be useful and I hope you beautiful people can contribute if you have the time <3

## Language support
Currently, peach supports 14 programming languages:\
`C#`, `C++`, `C`, `Python`, `Kotlin`, `Java`, `Rust`, `JavaScript`, `CSS`, `HTML`, `F#`, `Haskell`, `Ruby`, `Lua`

However, adding additional languages is incredibly simple. Simply insert a language into the switch case in `ProjectManager.cs` **in lowercase** and have it return the file extension used by the language.