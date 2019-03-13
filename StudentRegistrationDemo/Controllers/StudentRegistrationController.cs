using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StudentRegistrationDemo.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StudentRegistrationDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentRegistrationController : Controller
    {
        // POST api/<controller>
        [HttpPost]
        public StudentRegistrationReply RegisterStudent(Student studentRedg)
        {
            Console.WriteLine("In registerStudent");
            StudentRegistrationReply stdRedgReply = new StudentRegistrationReply();
            StudentRegistration.getInstance().Add(studentRedg);
            stdRedgReply.Name = studentRedg.Name;
            stdRedgReply.Age = studentRedg.Age;
            stdRedgReply.RegistrationNumber = studentRedg.RegistrationNumber;
            stdRedgReply.RegistrationStatus = "Successful";

            return stdRedgReply;
        }

        [HttpPost("InsertStudent")]
        public IActionResult InsertStudent(Student studentRegd)
        {
            Console.WriteLine("In registerStudent");
            StudentRegistrationReply stdregreply = new StudentRegistrationReply();
            StudentRegistration.getInstance().Add(studentRegd);
            stdregreply.Name = studentRegd.Name;
            stdregreply.Age = studentRegd.Age;
            stdregreply.RegistrationNumber = studentRegd.RegistrationNumber;
            stdregreply.RegistrationStatus = "Successful";

            return Ok(stdregreply);
        }

        [Route("student/")]
        [HttpPost("AddStudent")]
        public JsonResult AddStudent(Student studentregd)
        {
            Console.WriteLine("In registerStudent");
            StudentRegistrationReply stdregreply = new StudentRegistrationReply();
            StudentRegistration.getInstance().Add(studentregd);
            stdregreply.Name = studentregd.Name;
            stdregreply.Age = studentregd.Age;
            stdregreply.RegistrationNumber = studentregd.RegistrationNumber;
            stdregreply.RegistrationStatus = "Successful";
            return Json(stdregreply);
        }
    }
}
