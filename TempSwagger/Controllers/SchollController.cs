using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TempSwagger.DAL;
using TempSwagger.Models;

namespace TempSwagger.Controllers
{
    public class SchollController : Controller
    {
        #region Members
        SchollService schollService;
        #endregion

        #region Constructor
        public SchollController()
        {
            schollService = new SchollService();
        }
        #endregion

        #region Methods

        [HttpGet("GetAllClass")]
        public ActionResult<List<Class>> GetAllClass()
        {
            return schollService.GetAllClass();
        }

        [HttpGet("GetAllStudents")]
        public ActionResult<List<Student>> GetAllStudents()
        {
            return schollService.GetAllStudents();
        }

        [HttpGet("GetClassById/{id}")]
        public Class GetClasByID(int id)
        {
            return schollService.GetClassByID(id);
        }

        [HttpGet("GetClassByName/{name}")]
        public Class GetClassByName(string name)
        {
            return schollService.GetClassByName(name);
        }

        [HttpGet("GetStudentByClass/{classID}")]
        public ActionResult<List<Student>> GetStudenByClass(int classID)
        {
            return schollService.GetStudentByClass(classID);
        }

        [HttpGet("GetStudentByID/{id}")]
        public Student GetStudentByID(int id)
        {
            return schollService.GetStudentByID(id);
        }

        [HttpGet("GetStudentByName/{name}")]
        public Student GetStudentByName(string name)
        {
            return schollService.GetStudentByName(name);
        }

        [HttpPost("AddStudent")]
        public void AddStudent([FromBody]Student student)
        {
            schollService.AddStudent(student);
        }

        [HttpPost("AddClass")]
        public void AddClass([FromBody]Class _class)
        {
            schollService.AddClass(_class);
        }
        #endregion
    }
}