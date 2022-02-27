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
    public class DayCareController : ControllerBase
    {
        DayCareBL _DayCareBL = new DayCareBL();

        [HttpGet]
        //שליפה
        public IActionResult getAll()
        {
            return Ok(_DayCareBL.getAll());

        }

        [HttpPut]
        //עדכון
        public IActionResult uppdata(DayCareDTO DayCare)
        {
            return Ok(_DayCareBL.update(DayCare));

        }
        [HttpPost]
        //הוספה
        public IActionResult AddDayCare(DayCareDTO DayCare)
        {
            return Ok(_DayCareBL.AddDayCare(DayCare));

        }
        [HttpDelete]
        public IActionResult Delete(int IdDayCare)
        {
            return Ok(_DayCareBL.Delete(IdDayCare));

        }

    }


}

