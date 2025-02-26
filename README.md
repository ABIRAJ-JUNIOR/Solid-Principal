Student Management System (SMS) - SOLID Principles in C#

📌 Project Overview

This is a Student Management System built using C# while following the SOLID principles. The system allows an admin to add, view, and remove students, storing data using an interface for better flexibility and maintainability.

🚀 Features

✅ Add new students with ID, Name, Age, and Course
✅ Remove students by ID
✅ View all registered students
✅ Supports multiple storage implementations:

In-memory storage

Database storage (simulated)
✅ Follows SOLID principles for maintainable and scalable code

📌 SOLID Principles Applied

✔ S - Single Responsibility Principle (SRP): Each class handles a single responsibility.✔ O - Open/Closed Principle (OCP): New storage types can be added without modifying existing classes.✔ L - Liskov Substitution Principle (LSP): Storage classes can be replaced interchangeably.✔ I - Interface Segregation Principle (ISP): Small, specific interfaces are used.✔ D - Dependency Inversion Principle (DIP): High-level modules depend on abstractions (IStudentStorage).

📁 Project Structure

StudentManagementSystem/
│── Program.cs               # Main entry point
│── Student.cs               # Student model
│── IStudentStorage.cs       # Interface for storage abstraction
│── InMemoryStorage.cs       # Stores students in memory
│── DatabaseStorage.cs       # Simulated database storage
│── StudentService.cs        # Business logic for managing students
│── README.md                # Project documentation

🛠️ Setup & Run

Prerequisites

.NET Core 6+ installed

Any C# IDE (Visual Studio, VS Code, Rider, etc.)

Steps to Run

1️⃣ Clone the repository:

git clone https://github.com/ABIRAJ-JUNIOR/Solid-Principal.git
cd StudentManagementSystem

2️⃣ Open the project in your IDE.
3️⃣ Build and Run the application:

dotnet run

4️⃣ Follow on-screen instructions to add, remove, and view students.

🎯 Usage

1️⃣ Select storage type:

1 for In-Memory Storag
2 for Database Storage (Simulation)`

2️⃣ Choose an option:

1 ➝ Add Student
2 ➝ Remove Student
3 ➝ View All Students
4 ➝ Exit

🔥 Future Improvements

✅ Implement File Storage (e.g., JSON, XML)✅ Store students in a real database (SQL Server, MongoDB)✅ Add validation before adding students✅ Create a GUI version using WPF or Blazor

👨‍💻 Author

🔹 Your Name🔹 GitHub: ABIRAJ-JUNIOR🔹 Email: abirajjr2002@gmail.com

✅ Enjoy coding & learning SOLID Principles in C#! 🚀🔥
