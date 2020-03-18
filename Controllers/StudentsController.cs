using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ccw3.Models;
using Microsoft.AspNetCore.Mvc;

namespace ccw3.Controllers
{
    [ApiController]
    [Route("api/students")]
    public class StudentsController : ControllerBase
    {

        List<Student> studenci = new List<Student>();

        [HttpGet]
        public string GetStudent(string orderBy)
        {
            return $"Do re mi fa sortBy = {orderBy}";
        }

        [HttpGet("{id}")]
        public IActionResult GetStudent(int id)
        {

            if (id == 1)
            {
                return Ok("washi wa Lena");
            }
            else if (id == 2)
            {
                return Ok("Washi wa lena de wa arimasen");
            }

            return NotFound("Nie ma takiego studenta");
        }

        [HttpPost]
        public IActionResult CreateStudent(Student st)
        {

            st.IndexNumber = $"s{new Random().Next(1, 20000)}";
            st.FirstName = "Lena";
            st.LastName = "Do";
            st.IdStudent = 1;
            studenci.Add(st);
            return Ok(st);
        }
        
        [HttpPut("{id}")]
        public IActionResult ChangeId(int id, int newId)
        {
            if(id != newId)
            {
                //studenci.GetEnumerator = newId;
                // how to get something from list? there iss no get method...
            }
            else
            {
                return NoContent();
            }

            return Ok();
        }


    }
}