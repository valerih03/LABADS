using Microsoft.AspNetCore.Mvc;
using Web_APi_crud.Interfaces;
using Web_APi_crud.Models;

namespace Web_APi_crud.Controllers
{
    public class CarreraController : Controller
    { 
        private readonly ICarrera _carrera;
        public CarreraController(ICarrera carrera)
        {
            _carrera = carrera;
        }
        [HttpGet("api/Carreras")]
        public IActionResult Carreras()
        {
            return Ok(_carrera.Carreras());
        }
        [HttpGet("api/Carrera/{id}")]
        public IActionResult ConsultarCarrera(int id)
        {
            return Ok(_carrera.ConsultarCarrera(id));
        }
        [HttpPost("api/AgregarCarrera")]
        public IActionResult AgregarCarrera([FromBody] Carrera carrera)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(_carrera.AgregarCarrera(carrera));
        }

        [HttpPut("api/Carrera/{id}")]
        public IActionResult ActualizarCarrera(int id, [FromBody] Carrera carrera)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(_carrera.ActualizarCarrera(id, carrera));
        }

        [HttpDelete("api/Carrera/{id}")]
        public IActionResult EliminarCarrera(int id)
        {
            return Ok(_carrera.EliminarCarrera(id));
        }
    }
}
