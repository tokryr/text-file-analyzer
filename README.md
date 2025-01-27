## Text File Analyzer
A simple C# console application that reads a text file, analyzes its content, and displays statistics such as:

- Line count
- Word count
- Character counts (with and without spaces)
- Top 5 most frequent words

The application supports multiple file analyses in one run, includes basic error handling, and gracefully handles invalid file paths.

---

## Table of Contents

1. [Features](#features)  
2. [How It Works](#how-it-works)  
3. [Requirements](#requirements)  
4. [Installation](#installation)  
5. [Usage](#usage)  
   
---

## Features

- **Multiple File Analysis**: Prompts you to analyze additional files after each run.  
- **Error Handling**: Catches file-related exceptions (e.g., missing file, read errors) and prompts the user to try again.  
- **Word Frequency**: Identifies the top 5 most frequently used words in the text.  
- **Case-Insensitive**: Words are compared in lowercase form, ensuring “Hello” and “hello” are treated the same.

---

## How It Works

1. **Prompt for File Path**: The app asks for a text file path.  
2. **Validation**: Checks if the file exists and if it’s readable.  
3. **Analysis**:
   - Counts lines, words, characters.
   - Splits text into words by common delimiters (spaces, punctuation).
   - Groups and counts each word.
4. **Results**: Displays summary stats and top 5 words.  
5. **Repeat?**: Asks if you’d like to analyze another file (`y/n`).

---

## Requirements

- **.NET 6 SDK** (or higher) installed on your machine.
- A **command-line environment** (PowerShell, CMD, Terminal, etc.) or an IDE (Visual Studio, VS Code, Rider) to build and run the project.

---

Usage
-----

### Build & Run via .NET CLI

1.  **Build** the project:
    `dotnet build`

2.  **Run** the project:
    `dotnet run`

3.  When prompted, enter the **full path** to the text file you want to analyze (e.g., `C:\temp\sample.txt` on Windows or `/home/user/sample.txt` on Linux/Mac).

4.  Review the analysis results.

5.  Choose **y** to analyze another file, or **n** to exit.
