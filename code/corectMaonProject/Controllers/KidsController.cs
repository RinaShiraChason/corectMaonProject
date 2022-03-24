using BL;
using DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace corectMaonProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KidsController : ControllerBase
    {

        KidsBL _kidsBL = new KidsBL();

        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetAll()
        {
            return Ok(_kidsBL.GetAll());

        }

        [HttpGet]
        [Route("GetKidsByClassID/{classId}")]

        public IActionResult GetKidsByClassID(int classId)
        {
            return Ok(_kidsBL.GetKidsByClassID(classId));

        }
        [HttpGet]
        [Route("getKidsByTeachID/{teacherId}")]

        public IActionResult GetKidsByTeacher(int teacherId)
        {
            return Ok(_kidsBL.GetKidsByTeacher(teacherId));

        }

        [HttpGet]
        [Route("GetTodayKidsWithAttendenc/{classId}")]
        //שליפה
        public IActionResult GetTodayKidsWithAttendenc(int classId)
        {
            return Ok(_kidsBL.GetTodayKidsWithAttendenc(classId));

        }
        [HttpGet]
        [Route("GetTodayKidsWithDayCare/{classId}")]
        //שליפה
        public IActionResult GetTodayKidsWithDayCare(int classId)
        {
            return Ok(_kidsBL.GetTodayKidsWithDayCare(classId));

        }
        [HttpGet]
        [Route("GetTodayKidsData/{classId}")]
        //שליפה
        public IActionResult GetTodayKidsData(int classId)
        {
            return Ok(_kidsBL.GetTodayKidsData(classId));

        }
        [HttpGet]
        [Route("GetHistoryKidsData/{kidId}/{month}/{year}")]
        //שליפה
        public IActionResult GetHistoryKidsData(int kidId, int month, int year)
        {
            return Ok(_kidsBL.GetHistoryKidsData(kidId, month, year));

        }


        [HttpPost]
        [Route("AddUpdateKid")]
        //הוספה
        public IActionResult AddUpdateKid(KidsDTO kids)
        {
            return Ok(_kidsBL.AddUpdateKid(kids));

        }


        [HttpPut]
        //עדכון
        public IActionResult update(KidsDTO kids)
        {
            return Ok(_kidsBL.update(kids));
        }

        [HttpPost]
        //הוספה
        public IActionResult AddKids(KidsDTO kids)
        {
            return Ok(_kidsBL.AddKids(kids));

        }

        [HttpDelete]
        public IActionResult Delete(int tz)
        {
            return Ok(_kidsBL.Delete(tz));

        }

    }
}
