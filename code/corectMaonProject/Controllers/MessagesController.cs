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
        [Route("getAll")]
        //שליפה
        public IActionResult GetAll()
        {
            return Ok(_MessagesBL.GetAll());

        }

        [HttpGet]
        [Route("getMessgesByTeachID/{teacherId}")]

        public IActionResult GetMessgesByTeacher(int teacherId)
        {
            return Ok(_MessagesBL.GetMessagesByTo(teacherId));
        }

        [HttpGet]
        [Route("GetMessagesByTo/{id}")]
        //שליפה
        public IActionResult GetMessagesByTo(int id)
        {
            return Ok(_MessagesBL.GetMessagesByTo(id));



        }
        [HttpGet]
        [Route("GetMessagesNews")]
        //שליפה
        public IActionResult GetMessagesNews()
        {
            return Ok(_MessagesBL.GetMessagesNews());

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
        [Route("AddUpdateMessage")]
        //הוספה
        public IActionResult AddUpdateMessage(MessagesDTO Messages)
        {
            return Ok(_MessagesBL.AddUpdateMessage(Messages));

        }
        [HttpPost]
        [Route("SaveNews")]
        //הוספה
        public IActionResult SaveNews([FromBody] List<MessagesDTO> mNews)
        {
            return Ok(_MessagesBL.SaveNews(mNews));

        }
        
        [HttpPost]
        //הוספה
        public IActionResult AddMessages(MessagesDTO Messages)
        {
            return Ok(_MessagesBL.AddMessages(Messages));

        }
        [HttpDelete]
        [Route("delete/{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(_MessagesBL.Delete(id));

        }
   
   

    }
    public class MessagesNews {
        public List<MessagesDTO> News { get; set; }
    }
}
