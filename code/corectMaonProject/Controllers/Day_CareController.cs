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
    public class Day_CareController : ControllerBase
    {
        Day_CareBL _Day_CareBL = new Day_CareBL();

        [HttpGet]
        //שליפה
        public IActionResult getAll()
        {
            return Ok(_Day_CareBL.getAll());

        }

        [HttpPut]
        //עדכון
        public IActionResult uppdata(Day_CareDTO Day_Care)
        {
            return Ok();

        }
        [HttpPost]
        //הוספה
        public IActionResult AddDay_Care(Day_CareDTO Day_Care)
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

