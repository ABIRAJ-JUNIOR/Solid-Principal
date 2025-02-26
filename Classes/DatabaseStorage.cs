using Solid_Principal.Entities;
using Solid_Principal.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principal.Classes
{
    class DatabaseStorage : IStudentStorage
    {
        private List<Student> database = new List<Student>();

        public void AddStudent(Student student)
        {
            database.Add(student);
            Console.WriteLine($"Student {student.Name} saved to database.");
        }

        public void RemoveStudent(int id)
        {
            var student = database.FirstOrDefault(s => s.Id == id);
            if (student != null)
            {
                database.Remove(student);
                Console.WriteLine($"Student {student.Name} removed from database.");
            }
            else
            {
                Console.WriteLine("Student not found in database.");
            }
        }

        public List<Student> GetAllStudents()
        {
            return database;
        }
    }
}
