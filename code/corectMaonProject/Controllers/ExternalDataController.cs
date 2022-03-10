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
    public class ExternalDataController : ControllerBase
    {
        ExternalDataBL _ExternalDataBl = new ExternalDataBL();

        [HttpGet]
        //שליפה
        public IActionResult GetAll()
        {
            return Ok(_ExternalDataBl.GetAll());

        }

        [HttpPut]
        //עדכון
        public IActionResult update(ExternalDataDTO externalData)
        {
            return Ok(_ExternalDataBl.update(externalData));

        }
        [HttpPost]
        //הוספה
        public IActionResult AddExternalData(ExternalDataDTO externalData)
        {
            return Ok(_ExternalDataBl.AddExternalData(externalData));

        }
        [HttpDelete]
        public IActionResult Delete(int externalDataId)
        {
            return Ok(_ExternalDataBl.Delete(externalDataId));

        }
    }
}
