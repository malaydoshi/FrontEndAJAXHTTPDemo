using FrontEndAJAXHTTPDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FrontEndAJAXHTTPDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private static readonly Student[] students = new Student[] {
            new Student
            {
                SID = 1,
                SName = "Student 1",
                DTDOB = DateTime.Now,
                ARKnownLanguages = new[] { "Lang 1", "Lang 2" }
            },
            new Student {
                SID = 2,
                SName = "Student 2",
                DTDOB = DateTime.Now,
                ARKnownLanguages = new[] { "Lang 3", "Lang 4" }
            }
        };
        // GET: api/<StudentsController>
        [HttpGet]
        public IEnumerable<Student> Get()
        {
            return students;
        }

        // GET api/<StudentsController>/5
        [HttpGet("{SID}")]
        public Student Get(int SID)
        {
            return students.FirstOrDefault(student => student.SID == SID);
        }

        //// POST api/<StudentsController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<StudentsController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<StudentsController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
