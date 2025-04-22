using ApbdRestApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApbdRestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var animals = Database.Animals;
            return Ok(animals);
        }

        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            var animal = Database.Animals.FirstOrDefault(x => x.Id == id);
            return Ok(animal);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Animal animal)
        {
            Database.Animals.Add(animal);
            return Created();
        }

        [HttpPut("{id:int}")]
        public IActionResult Update(int id, [FromBody] Animal animal)
        {
            if (id != animal.Id)
            {
                return BadRequest("Id parameter in URL does not match id in request body.");
            }

            var existingAnimal = Database.Animals.FirstOrDefault(a => a.Id == id);

            if (existingAnimal == null)
            {
                return NotFound("Animal has not been found.");
            }

            existingAnimal.Name = animal.Name;
            existingAnimal.Category = animal.Category;
            existingAnimal.Weight = animal.Weight;
            existingAnimal.FurColor = animal.FurColor;

            return Ok(existingAnimal);
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            var animal = Database.Animals.FirstOrDefault(a => a.Id == id);
            if (animal == null)
            {
                return NotFound("Animal has not been found.");
            }

            Database.Animals.Remove(animal);
            return NoContent();
        }

        [HttpGet("{name}")]
        public IActionResult GetByName(string name)
        {
            var animals = Database.Animals.FindAll(a => a.Name == name);

            if (!animals.Any())
            {
                return NotFound($"No animal with name ${name} has been found.");
            }

            return Ok(animals);
        }
    }
}