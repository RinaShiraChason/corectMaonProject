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
    public class ClassesController : ControllerBase
    {
        ClassesBL _classesBL = new ClassesBL();

        [HttpGet]
        //שליפה
        public IActionResult getAll()
        {
            return Ok(_classesBL.getAll());

        }

        [HttpPut]
        //עדכון
        public IActionResult uppdata(ClassesDTO classes)
        {
            return Ok();

        }
        [HttpPost]
        //הוספה
        public IActionResult AddClasses(ClassesDTO classes)
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
