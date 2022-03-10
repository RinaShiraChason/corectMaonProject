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
    public class MessagesController : ControllerBase
    {
        MessagesBL _MessagesBL = new MessagesBL();

        [HttpGet]
        //שליפה
        public IActionResult GetAll()
        {
            return Ok(_MessagesBL.GetAll());

        }


        [HttpGet]
        [Route("GetMessagesByTo/{id}")]
        //שליפה
        public IActionResult GetMessagesByTo(int id)
        {
            return Ok(_MessagesBL.GetMessagesByTo(id));

        }
        [HttpGet]
        [Route("GetMessagesByFrom/{id}")]
        //שליפה
        public IActionResult GetMessagesByFrom(int id)
        {
            return Ok(_MessagesBL.GetMessagesByFrom(id));

        }
        [HttpPut]
        //עדכון
        public IActionResult update(MessagesDTO Messages)
        {
            return Ok(_MessagesBL.update(Messages));

        }
        [HttpPost]
        //הוספה
        public IActionResult AddMessages(MessagesDTO Messages)
        {
            return Ok(_MessagesBL.AddMessages(Messages));

        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            return Ok(_MessagesBL.Delete(id));

        }
   
   

    }
}
