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
    public class ActivityUpdateController: ControllerBase
    {
        ActivityUpdateBL _ActivityUpdateBL = new ActivityUpdateBL();

        [HttpGet]
        //שליפה
        public IActionResult getAll()
        {
            return Ok(_ActivityUpdateBL.getAll());

        }

        [HttpPut]
        //עדכון
        public IActionResult uppdata(ActivityUpdateDTO ActivityUpdate)
        {
            return Ok(_ActivityUpdateBL.update(ActivityUpdate));

        }
        [HttpPost]
        //הוספה
        public IActionResult AddActivityUpdate(ActivityUpdateDTO ActivityUpdate)
        {
            return Ok(_ActivityUpdateBL.AddActivityUpdate(ActivityUpdate));

        }
        [HttpDelete]
        public IActionResult Delete(int IdActivityUpdate)
        {
            return Ok(_ActivityUpdateBL.Delete(IdActivityUpdate));

        }

    }

}

