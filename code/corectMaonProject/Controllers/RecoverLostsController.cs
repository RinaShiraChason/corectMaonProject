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
    public class RecoverLostsController : ControllerBase
    {
       RecoverLostsBL _RecoverLostsBL = new RecoverLostsBL();

        [HttpGet]
        //שליפה
        public IActionResult getAll()
        {
            return Ok(_RecoverLostsBL.getAll());

        }

        [HttpPut]
        //עדכון
        public IActionResult update(RecoverLostsDTO RecoverLosts)
        {
            return Ok(_RecoverLostsBL.update(RecoverLosts));

        }
        [HttpPost]
        //הוספה
        public IActionResult AddRecoverLosts(RecoverLostsDTO RecoverLosts)
        {
            return Ok(_RecoverLostsBL.AddRecoverLosts(RecoverLosts));

        }
        [HttpDelete]
        public IActionResult Delete(int recoverLostsId)
        {
            return Ok(_RecoverLostsBL.Delete(recoverLostsId));

        }


    }
}
