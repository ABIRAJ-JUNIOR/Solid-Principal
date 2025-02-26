using Solid_Principal.Entities;
using Solid_Principal.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principal.Service
{
    class StudentService
    {
        private readonly IStudentStorage _studentStorage;

        public StudentService(IStudentStorage studentStorage)
        {
            _studentStorage = studentStorage;
        }

        public void AddStudent(int id, string name, int age, string course)
        {
            Student student = new Student(id, name, age, course);
            _studentStorage.AddStudent(student);
        }

        public void RemoveStudent(int id)
        {
            _studentStorage.RemoveStudent(id);
        }

        public void DisplayAllStudents()
        {
            var students = _studentStorage.GetAllStudents();
            if (students.Count == 0)
            {
                Console.WriteLine("No students found.");
                return;
            }
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }
    }
}
