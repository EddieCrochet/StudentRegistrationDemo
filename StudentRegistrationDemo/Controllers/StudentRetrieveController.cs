﻿using System;
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
    public class StudentRetrieveController : Controller
    {
        // GET: api/<controller>
        [HttpGet]
        public List<Student> GetAllStudents()
        {
            return StudentRegistration.getInstance().getAllStudent();
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
    }
}