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
        [Route("getAll")]
        public IActionResult getAll()
        {
            return Ok(_kidsBL.getAll());

        }
        [HttpGet]
        [Route("getKidsByTeachID/{teacherId}")]
       
        public IActionResult GetKidsByTeacher(int teacherId)
        {
            return Ok(_kidsBL.GetKidsByTeacher(teacherId));

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
