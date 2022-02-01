[![.NET Build](https://github.com/davidjamesmarley/ElevateProcess/actions/workflows/dotnet-build.yml/badge.svg?branch=main)](https://github.com/davidjamesmarley/ElevateProcess/actions/workflows/dotnet-build.yml)
![GitHub issues](https://img.shields.io/github/issues/davidjamesmarley/ElevateProcess?style=flat)
![GitHub closed issues](https://img.shields.io/github/issues-closed/davidjamesmarley/ElevateProcess?style=flat)
![GitHub pull requests](https://img.shields.io/github/issues-pr/davidjamesmarley/ElevateProcess?style=flat)
![GitHub closed pull requests](https://img.shields.io/github/issues-pr-closed/davidjamesmarley/ElevateProcess?style=flat)



# Elevate Process

Elevate Process is a simple utility for Windows that functions like the sudo utility does in Linux.

## Command-line Uage

Simply enter the name of the utility, then enter the name of the program you want to run elevated, followed by any aruments to be passed to that program.

If the utility or it's location is not included in your environment PATH variable, you will need to enter the full path and name of the utility. 

### Utility Usage

```

C:\> ep.exe <exe_path> [ <args> ] 

```
### Example 1: Run Notepad.exe as an elevated process


```

C:\MyWorkDirectory> ep.exe Notepad.exe MyNotes.txt

```

