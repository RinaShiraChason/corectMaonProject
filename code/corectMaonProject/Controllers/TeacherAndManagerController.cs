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
    public class TeacherAndManagerController : ControllerBase
    {
        TeacherAndManagerBL _TeacherAndManagerBL = new TeacherAndManagerBL();

        [HttpGet]
        //שליפה
        public IActionResult getAll()
        {
            return Ok(_TeacherAndManagerBL.getAll());

        }

        [HttpPut]
        //עדכון
        public IActionResult uppdata(TeacherAndManagerDTO TeacherAndManager)
        {
            return Ok();

        }
        [HttpPost]
        //הוספה
        public IActionResult AddTeacherAndManager(TeacherAndManagerDTO TeacherAndManager)
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
