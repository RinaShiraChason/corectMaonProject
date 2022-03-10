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
        [Route("GetAll")]
        //שליפה
        public IActionResult GetAll()
        {
            return Ok(_RecoverLostsBL.GetAll());

        }
        [HttpGet]
        [Route("GetById/{id}")]
        //שליפה
        public IActionResult GetById(int id)
        {
            return Ok(_RecoverLostsBL.GetById(id));

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

        [HttpPost]
        [Route("AddUpdateRecoverLost")]
        //הוספה
        public IActionResult AddUpdateRecoverLost(RecoverLostsDTO RecoverLosts)
        {
            return Ok(_RecoverLostsBL.AddUpdateRecoverLost(RecoverLosts));

        }
        [HttpDelete]
        public IActionResult Delete(int recoverLostsId)
        {
            return Ok(_RecoverLostsBL.Delete(recoverLostsId));

        }


    }
}
