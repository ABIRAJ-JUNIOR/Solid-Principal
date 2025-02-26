using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principal.Entities
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Course { get; set; }

        public Student(int id, string name, int age, string course)
        {
            Id = id;
            Name = name;
            Age = age;
            Course = course;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Age: {Age}, Course: {Course}";
        }
    }
}
