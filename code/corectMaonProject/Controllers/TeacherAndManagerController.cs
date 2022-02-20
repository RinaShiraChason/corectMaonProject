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
        public IActionResult uppdate(TeacherAndManagerDTO TeacherAndManager)
        {
            return Ok(_TeacherAndManagerBL.uppdate(TeacherAndManager));

        }
        [HttpPost]
        //הוספה
        public IActionResult AddTeacherAndManager(TeacherAndManagerDTO TeacherAndManager)
        {
            return Ok(_TeacherAndManagerBL.AddTeacherAndManager(TeacherAndManager));

        }
        [HttpDelete]
        public IActionResult Delete(long tz)
        {
            return Ok(_TeacherAndManagerBL.Delete(tz));

        }
   
   

        [HttpGet("{tz}/{pass}")]
        //שליפה לפי שם משתמש וסיסמה 
        public IActionResult getByTZAndPass(long tz,string pass)
        {
            return Ok(_TeacherAndManagerBL.getByTZAndPass(tz,pass));
        }
    }
}
