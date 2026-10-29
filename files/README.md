Markdown
# C# Windows Forms File Operations Application (Assignment 8)

A C# Windows Forms desktop application built on .NET Framework 4.7.2 that demonstrates fundamental file I/O operations using System.IO namespace classes (`StreamWriter`, `StreamReader`, `File`).

---

## Overview

This project provides an interactive Graphical User Interface (GUI) to showcase common operations on text files (`output.txt`). Users can create, read, process, and delete files or specific lines within files using standard Windows Forms controls.

---

## Key Features

* **Create File**: Generates a local text file (`output.txt`) and populates it with predefined sample text using `StreamWriter`.
* **Read All Text**: Reads all lines from `output.txt` and displays each line inside a `ListBox`.
* **Delete File**: Closes file handlers and permanently deletes `output.txt` from disk.
* **Delete Selected Item**: Removes a selected line from the `ListBox` and overwrites `output.txt` with the updated content.
* **Read All Bytes**: Reads `output.txt` as a binary byte array and outputs the file size in bytes to the display.
* **Read Block**: Uses a `StreamReader` buffer to read up to the first 20 characters of the file into memory.

---

## Project Structure

```text
assignment8/
│
├── App.config               # Application configuration settings
├── assignment8.csproj       # C# Project file (.NET Framework 4.7.2)
├── Form1.cs                 # Main form event handlers and logic
├── Form1.Designer.cs        # Visual Studio Designer generated code
├── Form1.resx               # Resource file for Form1
├── Program.cs               # Application entry point
└── Properties/              # Assembly and project properties
Requirements
OS: Windows 10/11

Framework: .NET Framework 4.7.2 or higher

IDE: Visual Studio 2019 / 2022 (with .NET Desktop Development workload installed)

How to Run
Clone or Download the project repository.

Open assignment8.csproj in Visual Studio.

Press F5 or click Start to build and run the application.

Interact with the buttons on the form to perform various file operations.