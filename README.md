# Library-Managment-System
Library Management System (C#)

Description
Simple console-based library system demonstrating OOP concepts: Encapsulation, Inheritance, Abstract Classes, and Methods.
Members (Student & Teacher) can borrow/return books and calculate late fees.

Classes

Book: title, author, isBorrowed; methods: Borrow(), Return(), getters and setters.

Member (abstract): name, id; abstract methods: BorrowBook(), ReturnBook(), CalculateLateFee().

StudentMember: implements Member; fee = 0.5 * daysLate.

TeacherMember: implements Member; fee = 0.2 * daysLate.

Usage
Run Program class.
Demonstrates creating books/members, borrowing, returning late, and printing actions.

Example Output :
Teacher Ahmad borrowed Clean Code by Mark Skeet
Student Khalid borrowed C# Basics by John Doe
Student Khalid returned C# Basics , late fee: 2 JOD
Teacher Ahmad returned Clean Code , late fee: 0.6 JOD
