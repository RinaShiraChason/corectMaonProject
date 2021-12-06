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
    public class Placement_Of_A_TeacherController : ControllerBase
    {
        Placement_Of_A_TeacherBL _Placement_Of_A_TeacherBL = new Placement_Of_A_TeacherBL();

        [HttpGet]
        //שליפה
        public IActionResult getAll()
        {
            return Ok(_Placement_Of_A_TeacherBL.getAll());

        }

        [HttpPut]
        //עדכון
        public IActionResult uppdata(Placement_Of_A_TeacherDTO Placement_Of_A_Teacher)
        {
            return Ok();

        }
        [HttpPost]
        //הוספה
        public IActionResult AddPlacement_Of_A_Teacher(Placement_Of_A_TeacherDTO Placement_Of_A_Teacher)
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
