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
    public class Kids_AttendanceController : ControllerBase
    {
        Kids_AttendanceBL _Kids_AttendanceBL = new Kids_AttendanceBL();

        [HttpGet]
        //שליפה
        public IActionResult getAll()
        {
            return Ok(_Kids_AttendanceBL.getAll());

        }

        [HttpPut]
        //עדכון
        public IActionResult uppdata(Kids_AttendanceDTO Kids_Attendance)
        {
            return Ok();

        }
        [HttpPost]
        //הוספה
        public IActionResult AddKids_Attendance(Kids_AttendanceDTO Kids_Attendance)
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
