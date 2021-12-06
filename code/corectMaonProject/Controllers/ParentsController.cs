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
        public IActionResult uppdata(ParentsDTO Parents)
        {
            return Ok();

        }
        [HttpPost]
        //הוספה
        public IActionResult AddParents(ParentsDTO Parents)
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
