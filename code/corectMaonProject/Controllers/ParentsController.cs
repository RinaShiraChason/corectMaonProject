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
    public class ParentsController : ControllerBase
    {
        ParentsBL _ParentsBL = new ParentsBL();

        [HttpGet]
        //שליפה
        public IActionResult getAll()
        {
            return Ok(_ParentsBL.getAll());

        }

        [HttpPut]
        //עדכון
        public IActionResult uppdate(ParentsDTO Parents)
        {
            return Ok(_ParentsBL.uppdate(Parents));

        }
        [HttpPost]
        //הוספה
        public IActionResult AddParents(ParentsDTO Parents)
        {
            return Ok(_ParentsBL.AddParents(Parents));

        }
        [HttpDelete]
        public IActionResult Delete(int ParentsId)
        {
            return Ok(_ParentsBL.Delete(ParentsId));

        }


        [HttpGet("{tz}/{pass}")]
        //שליפה לפי שם משתמש וסיסמה 
        public IActionResult getByTZAndPass(long tz, string pass)
        {
            return Ok(_ParentsBL.getByTZAndPass(tz, pass));
        }
    }
}
