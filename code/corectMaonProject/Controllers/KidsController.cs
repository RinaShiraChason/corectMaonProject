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
        //שליפה
        public IActionResult getAll()
        {
            return Ok(_kidsBL.getAll());

        }

        [HttpPut]
        //עדכון
        public IActionResult uppdata(KidsDTO kids)
        {
            return Ok();

        }
        [HttpPost]
        //הוספה
        public IActionResult AddKids(KidsDTO kids)
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
