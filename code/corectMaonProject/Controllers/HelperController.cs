using BL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
//using System.Web.Http.Cors;


namespace corectMaonProject.Controllers
{
    public class HelperController : Controller
    {
        RecoverLostsBL _RecoverLostsBL = new RecoverLostsBL();


        [Microsoft.AspNetCore.Mvc.HttpPost("uploadImage/{id}")]
        public async Task<IActionResult> Index(IFormFile file,int id)
         {

            if (file == null || file.Length == 0)
                return Content("file not selected");
            var fileName = Guid.NewGuid() + ".jpg";
            var path = Path.Combine(
                        Directory.GetCurrentDirectory(), "wwwroot",
                        fileName);

            using (var stream = new FileStream(path, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }
            bool result = _RecoverLostsBL.UploadImage(id, fileName);
            if (result)
                return Ok("success");


            //var rec = id;
            ////Create custom filename
            //if (file != null)
            //{
            //    var fileName = Guid.NewGuid() + ".jpg";
            //    var filePath = HttpContext.Current.Server.MapPath("~/UploadFile/" + fileName);
            //    file.SaveAs(filePath);
            //    bool result = Bll.Products.UploadImage(Barcode, fileName);
            //    if (result)
            //        return Ok("success");

            //}
            return BadRequest("problem");

        }
    }
}
