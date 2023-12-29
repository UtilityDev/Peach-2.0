# peach 2.0 🍑

## What is it?
Peach is a CLI application that automatically sets up programming projects for you! You can make `typical` projects (literally everything not web related) or `web` projects. You give it a name, a language, and a directory, and peach sets everything up for you. Even though it is **VERY** basic in its current state, you can always make a pull request and add new features 😉

## Language support
Currently, peach supports 14 programming languages:
`C#`, `C++`, `C`, `Python`, `Kotlin`, `Java`, `Rust`, `JavaScript`, `CSS`, `HTML`, `F#`, `Haskell`, `Ruby`, `Lua`
However, adding new languages is extremely simple. In `ProjectManager.cs`, just insert a language **in lowercase** into the switch statement and have it return the file extension used by the language.