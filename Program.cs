using Solid_Principal.Classes;
using Solid_Principal.Interface;
using Solid_Principal.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select Storage Type:");
            Console.WriteLine("1. In-Memory");
            Console.WriteLine("2. Database (Simulation)");
            Console.Write("Enter choice: ");

            int choice = int.Parse(Console.ReadLine());

            IStudentStorage storage = (choice == 1 ? new InMemoryStorage() : new DatabaseStorage());
            StudentService studentService = new StudentService(storage);

            while (true)
            {
                Console.WriteLine("\n1. Add Student");
                Console.WriteLine("2. Remove Student");
                Console.WriteLine("3. View All Students");
                Console.WriteLine("4. Exit");
                Console.Write("Enter choice: ");

                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.Write("Enter ID: ");
                        int id = int.Parse(Console.ReadLine());
                        Console.Write("Enter Name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter Age: ");
                        int age = int.Parse(Console.ReadLine());
                        Console.Write("Enter Course: ");
                        string course = Console.ReadLine();

                        studentService.AddStudent(id, name, age, course);
                        break;

                    case 2:
                        Console.Write("Enter Student ID to remove: ");
                        int removeId = int.Parse(Console.ReadLine());
                        studentService.RemoveStudent(removeId);
                        break;

                    case 3:
                        studentService.DisplayAllStudents();
                        break;

                    case 4:
                        return;

                    default:
                        Console.WriteLine("Invalid choice, try again.");
                        break;
                }
            }
        }
    }
}
