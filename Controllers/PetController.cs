using Microsoft.AspNetCore.Mvc;
using PetApp.Interface;
using PetApp.Models;

namespace PetApp.Controllers
{
    // Attributes to turn the class into a controller
    [Route("api/[controller]")]
    [ApiController]
    public class PetController : Controller
    {
        private readonly iPetRepository _petRepository;
        public PetController(iPetRepository petRepository)
        {
               _petRepository = petRepository;
        }
        [HttpGet]
        [ProducesResponseType(200, Type= typeof(IEnumerable<Pet>))]
        public IActionResult GetPets()
        {
            var pets = _petRepository.GetPets();

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(pets);
        }

    }
}
