using MilenaŁukasikLab5.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MilenaŁukasikLab5.Controllers
{
    [RoutePrefix("api/students")]
    public class StudentController : ApiController
    {
        [Route("GetAll")]
        [HttpGet]
        public IHttpActionResult GetAll()
        {
            IEnumerable<Student> students;
            using(var context = new EfDbContext())
            {
                students = context.Students.Include(s => s.Grades).ToList();
            }
            return Ok(students);
        }
        
        [Route("Get/{id:int}")]
        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            Student student;
            using (var context = new EfDbContext())
            {
                student = context.Students.Include(s => s.Grades).SingleOrDefault(s => s.Id == id);
            }
            return Ok(student);
        }

        // POST: api/Student
        [Route("")]
        [HttpPost]
        public IHttpActionResult Post([FromBody]Student student)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            using(var context = new EfDbContext())
            {
                context.Students.Add(student);
                context.SaveChanges();
            }

            return CreatedAtRoute("GetStudent", new { id = student.Id }, student);
        }

        // PUT: api/Student/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Student/5
        public void Delete(int id)
        {
        }
    }
}
