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
    public class ImagesController : ControllerBase
    {
        ImagesBL _ImagesBl = new ImagesBL();

        [HttpGet]
        //שליפה
        public IActionResult GetAll()
        {
            return Ok(_ImagesBl.GetAll());

        }
        [HttpGet]
        [Route("GetAllByClassId/{classId}")]
        //שליפה
        public IActionResult GetAllByClassId(int classId)
        {
            return Ok(_ImagesBl.GetAllByClassId(classId));

        }

        [HttpGet]
        [Route("GetById/{id}")]
        //שליפה
        public IActionResult GetById(int id)
        {
            return Ok(_ImagesBl.GetById(id));

        }
        
        //
        [HttpPut]
        //עדכון
        public IActionResult update(ImagesDTO image)
        {
            return Ok(_ImagesBl.update(image));

        }
        [HttpPost]
        //הוספה
        public IActionResult AddImages(ImagesDTO image)
        {
            return Ok(_ImagesBl.AddImages(image));

        }
        [HttpPost("AddUpdateImage")]
        //הוספה
        public IActionResult AddUpdateImage(ImagesDTO image)
        {
            return Ok(_ImagesBl.AddUpdateImage(image));

        }

        


        [HttpDelete("Delete/{imageId}")]
        public IActionResult Delete(int imageId)
        {
            return Ok(_ImagesBl.Delete(imageId));

        }
    }
}
