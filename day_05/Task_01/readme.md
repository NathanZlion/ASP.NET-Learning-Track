# Student Management System

## Description: 
Create a console application for managing students' information. Implement a generic class to store and manage student data. The program should allow the user to add new students, search for students by name or ID, display a list of all students, and serialize/deserialize the student data to/from a JSON file.

## Requirements:
- Create a class named "Student" with properties like Name, Age, RollNumber, and Grade.
- Implement a generic class called `StudentList<T>` to manage a list of Student objects.
- Use LINQ to search for students by name or ID.
- Implement serialization and deserialization of `StudentList<T>` to/from a JSON file.
- Use readonly keyword for the RollNumber property to ensure immutability.

