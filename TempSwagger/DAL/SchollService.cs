using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TempSwagger.Models;

namespace TempSwagger.DAL
{
    public class SchollService : ISchollService
    {
        #region StaticData
        public static List<Class> classList = new List<Class>()
        {
            new Class{ID=1,Name="1-A",Population=30,TeacherName="X Hanım"},
            new Class{ID=2,Name="1-B",Population=20,TeacherName="Y Hanım"},
            new Class{ID=3,Name="2-A",Population=22,TeacherName="Z Bey"},
            new Class{ID=4,Name="2-B",Population=25,TeacherName="Temp Teacher"},
        };

        public static List<Student> studentList = new List<Student>()
        {
            new Student{ID=1,Name="Ahmet",Age=7,Gender="Erkek",No=001,ClassID=1},
            new Student{ID=1,Name="Hamza",Age=7,Gender="Erkek",No=002,ClassID=1},
            new Student{ID=1,Name="Ayşe",Age=7,Gender="Kız",No=003,ClassID=1},
            new Student{ID=1,Name="Hüseyin",Age=8,Gender="Erkek",No=004,ClassID=2},
            new Student{ID=1,Name="Elif",Age=8,Gender="Kız",No=005,ClassID=2},
        };
        #endregion
        public void AddClass(Class _class)
        {
            classList.Add(_class);
        }

        public void AddStudent(Student student)
        {
            studentList.Add(student);
        }

        public List<Class> GetAllClass()
        {
            return classList;
        }

        public List<Student> GetAllStudents()
        {
            return studentList;
        }

        public Class GetClassByID(int id)
        {
            return classList.Find(x => x.ID == id);
        }

        public Class GetClassByName(string name)
        {
            return classList.Find(x => x.Name == name);
        }

        public List<Student> GetStudentByClass(int classID)
        {
            return studentList.FindAll(x => x.ClassID == classID);
        }

        public Student GetStudentByID(int id)
        {
            return studentList.Find(x => x.ID == id);
        }

        public Student GetStudentByName(string name)
        {
            return studentList.Find(x => x.Name == name);
        }
    }
}
