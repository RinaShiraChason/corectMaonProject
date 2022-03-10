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
    public class UserController : ControllerBase
    {
        UserBL _UserBL = new UserBL();

        [HttpGet]
        //שליפה
        public IActionResult GetAll()
        {
            return Ok(_UserBL.GetAll());

        }

        [HttpPut]
        //עדכון
        public IActionResult Update(UserDTO User)
        {
            return Ok(_UserBL.update(User));

        }
        [HttpPost]
        //הוספה
        public IActionResult AddUser(UserDTO User)
        {
            return Ok(_UserBL.AddUser(User));

        }

        [HttpPost]
        [Route("Login")]
        //הוספה
        public IActionResult Login(UserDTO User)
        {
            return Ok(_UserBL.Login(User));

        }
        [HttpDelete]
        public IActionResult Delete(int UserTz)
        {
            return Ok(_UserBL.Delete(UserTz));

        }

    }
}
