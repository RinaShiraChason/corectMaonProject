using BL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
//using System.Web.Http.Cors;

namespace corectMaonProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelperController : Controller
    {
        RecoverLostsBL _RecoverLostsBL = new RecoverLostsBL();
        ImagesBL _ImageBL = new ImagesBL();

        [HttpPost("uploadImage/{id:int}/forms"), DisableRequestSizeLimit]

        public async Task<IActionResult> uploadImage(int id, [FromForm] UploadForm form)
        {
            var file = form.UploadFile;
            var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), "UploadFile");
            if (file.Length > 0)
            {
                var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                var ext = Path.GetExtension(fileName);
                fileName = Guid.NewGuid()  + ext;
                var fullPath = Path.Combine(pathToSave, fileName);
               
                using (var stream = new FileStream(fullPath, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }
                bool result = _RecoverLostsBL.UploadImage(id, fileName);
                if (result)
                    return Ok(true);
            }

            return BadRequest();

        }
        [HttpPost("UploadImageTable/{id:int}/forms"), DisableRequestSizeLimit]

        public async Task<IActionResult> UploadImageTable(int id, [FromForm] UploadForm form)
        {
            var file = form.UploadFile;
            var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), "UploadFile");
            if (file.Length > 0)
            {
                var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                var ext = Path.GetExtension(fileName);
                fileName = Guid.NewGuid() + ext;
                var fullPath = Path.Combine(pathToSave, fileName);

                using (var stream = new FileStream(fullPath, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }
                bool result = _ImageBL.UploadImage(id, fileName);
                if (result)
                    return Ok(true);
            }

            return BadRequest();

        }
        

    }
    public class UploadForm
    {
        public int FormId { get; set; }
        public string[] Courses { get; set; }
        public IFormFile UploadFile { get; set; }
    }
}
