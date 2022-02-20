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
    public class Activity_UpdateController: ControllerBase
    {
        Activity_UpdateBL _Activity_UpdateBL = new Activity_UpdateBL();

        [HttpGet]
        //שליפה
        public IActionResult getAll()
        {
            return Ok(_Activity_UpdateBL.getAll());

        }

        [HttpPut]
        //עדכון
        public IActionResult uppdata(Activity_UpdateDTO Activity_Update)
        {
            return Ok(_Activity_UpdateBL.uppdate(Activity_Update));

        }
        [HttpPost]
        //הוספה
        public IActionResult AddActivity_Update(Activity_UpdateDTO Activity_Update)
        {
            return Ok(_Activity_UpdateBL.AddActivity_Update(Activity_Update));

        }
        [HttpDelete]
        public IActionResult Delete(int IdActivityUpdate)
        {
            return Ok(_Activity_UpdateBL.Delete(IdActivityUpdate));

        }

    }

}

