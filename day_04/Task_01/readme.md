# Simple Task Manager Project

## Objective:
This project will provide a beginner-friendly application that uses various concepts in C#, enabling you to practice enums, object initializers, lambda expressions, asynchronous programming, and exception handling in a manageable project.

## Description:
The Simple Task Manager is a console-based application that allows users to manage their tasks by adding and viewing them. It will demonstrate the use of enums to categorize tasks, object initializers to create Task objects, lambda expressions for filtering tasks, and asynchronous programming to handle file operations.

## Features:
- Enumerated Task Categories:
    - Create an enum to represent different categories of tasks, such as Personal, Work, Errands, etc.

- Task Class with Object Initializers:
    - Define a Task class with properties: Name, Description, Category (using the enum), and IsCompleted.
    - Use object initializers to create and populate Task objects.

- Task Manager Operations:
    - Implement functionality to add new tasks to the Task Manager.
    - Display a list of tasks with their details (name, description, category, and completion status).

- Lambda Expression Filtering:
    - Add options to view tasks based on categories (e.g., show only Work tasks or Personal tasks).
    - Use lambda expressions to filter and display tasks based on user-selected categories.

- Asynchronous File Operations:
    - Store tasks in a CSV file using asynchronous file writing.
    - Use async/await pattern to read task data from the file asynchronously when the application starts.

- Exception handling
    - Implement robust exception handling to handle file-related exceptions during read and write operations.

