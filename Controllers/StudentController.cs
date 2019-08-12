using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        readonly StudentRepository _studentRepository;

        public StudentController()
        {
            _studentRepository = new StudentRepository();
        }
        [HttpPost("")]
        public ActionResult AddStudent(CreateStudentRequest createRequest)
        {

            var newStudent = _studentRepository.AddStudent(createRequest.FirstName, createRequest.LastName);
            return Created($"/api/student/{newStudent.Id}", newStudent);

        }
    }
}