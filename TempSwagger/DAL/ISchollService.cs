using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TempSwagger.Models;

namespace TempSwagger.DAL
{
    public interface ISchollService
    {
        List<Class> GetAllClass();
        Class GetClassByID(int id);
        Class GetClassByName(string name);
        List<Student> GetAllStudents();
        List<Student> GetStudentByClass(int classID);
        Student GetStudentByID(int id);
        Student GetStudentByName(string name);

        void AddStudent(Student student);
        void AddClass(Class _class);

    }
}
