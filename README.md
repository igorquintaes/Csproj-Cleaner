# Csproj-Cleaner | Project Cleaner

This application can be used to remove somes references that was duplicated inside project files, as .csproj, .vsproj and  others Visual Studio project files. Some of the duplicated references can broke solution - it can be unable to build or run. Other cases, like files that are not used in build proccess but as resource, the duplicated reference will not broke the solution, but show a two or more times the same file in Solution Explorer windows. Both cases the application works to remove these invalid references.


![Preview](https://raw.githubusercontent.com/igorquintaes/Csproj-Cleaner/master/example-duplicated.png)


# How to use

1. Open the application if you have the .exe, or just run the solution to open the program.
2. Select a directory where the applicaition will check and clean duplicated references from all projects inside. It also checks subdirectories.
3. Optionally, Select a directory to save a log with informations about the run.
4. Optionally, you can open the Settings menu and select your desired language and filter project files by extension.
4. Optionally, you can check if the program will remove references from non existent files.
5. Click in run button to start. A popup with a report appears when it ends.

# Features

* Only one run needed,
* Filter the project files using extensions, to only clean the desired files,
* Multi-language support,
* Remove or log invalid references from non existent files,
* Save previous paths.
