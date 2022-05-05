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
        [HttpGet]
        [Route("GetAllByClassId/{classID}")]
        //שליפה
        public IActionResult GetAllByClassId(int classID)
        {
            return Ok(_ExternalDataBl.GetAllByClassID(classID));

        }
        [HttpPut]
        //עדכון
        public IActionResult update(ExternalDataDTO externalData)
        {
            return Ok(_ExternalDataBl.update(externalData));

        }

        [Route("AddUpdateExtData")]
        [HttpPost]
        //הוספה
        public IActionResult AddUpdateExtData(ExternalDataDTO externalData)
        {
            return Ok(_ExternalDataBl.AddUpdateExtData(externalData));

        }
        [HttpPost]
        //הוספה
        public IActionResult AddExternalData(ExternalDataDTO externalData)
        {
            return Ok(_ExternalDataBl.AddExternalData(externalData));

        }
        [HttpDelete("Delete/{externalDataId}")]
        public IActionResult Delete(int externalDataId)
        {
            return Ok(_ExternalDataBl.Delete(externalDataId));

        }
    }
}
