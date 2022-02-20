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
        public IActionResult uppdate(Kids_AttendanceDTO Kids_Attendance)
        {
            return Ok(_Kids_AttendanceBL.uppdate(Kids_Attendance));

        }
        [HttpPost]
        //הוספה
        public IActionResult AddKids_Attendance(Kids_AttendanceDTO Kids_Attendance)
        {
            return Ok(_Kids_AttendanceBL.AddKids_Attendance(Kids_Attendance));

        }
        [HttpDelete]
        public IActionResult Delete(int AttendanceId)
        {
            return Ok(_Kids_AttendanceBL.Delete(AttendanceId));

        }
    }
}
