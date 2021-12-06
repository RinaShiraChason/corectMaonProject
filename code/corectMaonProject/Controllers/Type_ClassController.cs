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
    public class Type_ClassController : ControllerBase
    {
        Type_ClassBL _Type_ClassBL = new Type_ClassBL();

        [HttpGet]
        //שליפה
        public IActionResult getAll()
        {
            return Ok(_Type_ClassBL.getAll());

        }

        [HttpPut]
        //עדכון
        public IActionResult uppdata(Type_ClassDTO Type_Class)
        {
            return Ok();

        }
        [HttpPost]
        //הוספה
        public IActionResult AddType_Class(Type_ClassDTO Type_Class)
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
