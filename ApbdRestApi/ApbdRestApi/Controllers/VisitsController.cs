using ApbdRestApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApbdRestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Visits : ControllerBase
    {
        [HttpGet]
        public IActionResult GetByAnimal([FromBody] Animal animal)
        {
            var visits = Database.Visits.Where(v => v.Animal == animal);
            return Ok(visits);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Visit visit)
        {
            if (!Database.Animals.Contains(visit.Animal))
            {
                return NotFound("Animal has not been found.");
            }

            Database.Visits.Add(visit);
            return Created();
        }
    }
}