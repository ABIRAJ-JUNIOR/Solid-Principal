using Solid_Principal.Entities;
using Solid_Principal.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principal.Classes
{
    class InMemoryStorage : IStudentStorage
    {
        private List<Student> students = new List<Student>();

        public void AddStudent(Student student)
        {
            students.Add(student);
            Console.WriteLine($"Student {student.Name} added successfully.");
        }

        public void RemoveStudent(int id)
        {
            var student = students.FirstOrDefault(s => s.Id == id);
            if (student != null)
            {
                students.Remove(student);
                Console.WriteLine($"Student {student.Name} removed successfully.");
            }
            else
            {
                Console.WriteLine("Student not found.");
            }
        }

        public List<Student> GetAllStudents()
        {
            return students;
        }
    }
}
