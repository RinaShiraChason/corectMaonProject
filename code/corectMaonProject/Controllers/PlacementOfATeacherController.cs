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
    public class PlacementOfATeacherController : ControllerBase
    {
        PlacementOfATeacherBL _Placement_Of_A_TeacherBL = new PlacementOfATeacherBL();

        [HttpGet]
        //שליפה
        public IActionResult getAll()
        {
            return Ok(_Placement_Of_A_TeacherBL.getAll());

        }

        [HttpPut]
        //עדכון
        public IActionResult update(PlacementOfATeacherDTO Placement_Of_A_Teacher)
        {
            return Ok(_Placement_Of_A_TeacherBL.update(Placement_Of_A_Teacher));

        }
        [HttpPost]
        //הוספה
        public IActionResult AddPlacementOfATeacher(PlacementOfATeacherDTO Placement_Of_A_Teacher)
        {
            return Ok(_Placement_Of_A_TeacherBL.AddPlacementOfATeacher(Placement_Of_A_Teacher));

        }
        [HttpDelete]
        public IActionResult Delete(int IdPlacementOfATeacher)
        {
            return Ok(_Placement_Of_A_TeacherBL.Delete(IdPlacementOfATeacher));

        }

    }
}
