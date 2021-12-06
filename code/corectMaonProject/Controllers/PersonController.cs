using BL;
using DTO;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace corectMaonProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        PersonBL _PersonBL = new PersonBL();

        [HttpGet]
        //שליפה
        public IActionResult getAll()
        {
            return Ok(_PersonBL.getAll());

        }

        [HttpPut]
        //עדכון
        public IActionResult uppdata(PersonDTO Person)
        {
            return Ok();

        }
        [HttpPost]
        //הוספה
        public IActionResult AddPerson(PersonDTO Person)
        {
            return Ok();

        }
        [HttpDelete]
        public IActionResult Delete()
        {
            return Ok();

        }

    }
}
