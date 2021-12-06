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
    public class Type_EmployeeController : ControllerBase
    {
        Type_EmployeeBL _Type_EmployeeBL = new Type_EmployeeBL();

        [HttpGet]
        //שליפה
        public IActionResult getAll()
        {
            return Ok(_Type_EmployeeBL.getAll());

        }

        [HttpPut]
        //עדכון
        public IActionResult uppdata(Type_EmployeeDTO Type_Employee)
        {
            return Ok();

        }
        [HttpPost]
        //הוספה
        public IActionResult AddType_Employee(Type_EmployeeDTO Type_Employee)
        {
            return Ok();

        }
        [HttpDelete]
        public IActionResult Delete()
        {
            return Ok();

        }
    }
}
