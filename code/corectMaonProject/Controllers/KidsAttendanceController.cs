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
    public class KidsAttendanceController : ControllerBase
    {
        KidsAttendanceBL _Kids_AttendanceBL = new KidsAttendanceBL();

        [HttpGet]
        //שליפה
        public IActionResult GetAll()
        {
            return Ok(_Kids_AttendanceBL.GetAll());

        }
   
        [HttpPut]
        //עדכון
        public IActionResult update(KidsAttendanceDTO Kids_Attendance)
        {
            return Ok(_Kids_AttendanceBL.update(Kids_Attendance));

        }
        [HttpPost]
        //הוספה
        public IActionResult AddKids_Attendance(KidsAttendanceDTO Kids_Attendance)
        {
            return Ok(_Kids_AttendanceBL.AddKids_Attendance(Kids_Attendance));

        }

        [HttpPost]
        [Route("SetKidAttendence")]
        //הוספה
        public IActionResult SetKidAttendence(KidsAttendanceDTO Kids_Attendance)
        {
            return Ok(_Kids_AttendanceBL.SetKidAttendence(Kids_Attendance));

        }
        
        [HttpDelete]
        public IActionResult Delete(int AttendanceId)
        {
            return Ok(_Kids_AttendanceBL.Delete(AttendanceId));

        }
    }
}
