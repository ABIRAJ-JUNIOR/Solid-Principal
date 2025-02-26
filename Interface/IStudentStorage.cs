using Solid_Principal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principal.Interface
{
    interface IStudentStorage
    {
        void AddStudent(Student student);
        void RemoveStudent(int id);
        List<Student> GetAllStudents();
    }
}
