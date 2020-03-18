using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ccw3.Controllers
{
    [ApiController]
    [Route("api/students")]
    public class StudentsController : ControllerBase
    {
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


    }
}