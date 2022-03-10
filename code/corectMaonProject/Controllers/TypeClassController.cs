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
    public class TypeClassController : ControllerBase
    {
        TypeClassBL _TypeClassBL = new TypeClassBL();

        [HttpGet]
        //שליפה
        public IActionResult GetAll()
        {
            return Ok(_TypeClassBL.GetAll());

        }

        [HttpPut]
        //עדכון
        public IActionResult update(TypeClassDTO TypeClass)
        {
            return Ok(_TypeClassBL.update(TypeClass));

        }
        [HttpPost]
        //הוספה
        public IActionResult AddTypeClass(TypeClassDTO TypeClass)
        {
            return Ok(_TypeClassBL.AddTypeClass(TypeClass));

        }
        [HttpDelete]
        public IActionResult Delete(int IdTypeClass)
        {
            return Ok(_TypeClassBL.Delete(IdTypeClass));

        }

    }
}
