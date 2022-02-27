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
        public IActionResult getAll()
        {
            return Ok(_ImagesBl.getAll());

        }

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
        [HttpDelete]
        public IActionResult Delete(int imageId)
        {
            return Ok(_ImagesBl.Delete(imageId));

        }
    }
}
