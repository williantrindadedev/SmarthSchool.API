using Microsoft.AspNetCore.Mvc;

namespace SmarthSchool.API.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class ProfessorController : ControllerBase
    {
        public ProfessorController()
        {
            
        }

        [HttpGet]
        public IActionResult Get()
        {
            return  Ok("Professor: Willian");
        }


    }
}