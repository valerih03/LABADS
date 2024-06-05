using Microsoft.AspNetCore.Mvc;
using Web_APi_crud.Interfaces;
using Web_APi_crud.Models;

namespace Web_APi_crud.Controllers
{
    public class ProfesorController : Controller
    {
        private readonly IProfesor _profesor;

        public ProfesorController(IProfesor profesor)
        {
            _profesor = profesor;
        }

        [HttpGet("api/proferes")]
        public IActionResult Profesores()
        {
            return Ok(_profesor.Profesores());
        }

        [HttpGet("api/profesor/{id}")]
        public IActionResult ConsultarProfesor(int id)
        {
            return Ok(_profesor.ConsultarProfesor(id));
        }

        [HttpPost("api/AgregarProfesor")]
        public IActionResult AgregarProfesor([FromBody] Profesor profesor)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(_profesor.AgregarProfesor(profesor));
        }

        [HttpPut("api/profesor/{id}")]
        public IActionResult ActualizarProfesor(int id, [FromBody] Profesor profesor)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(_profesor.ActualizarProfesor(id, profesor));
        }

        [HttpDelete("api/profesor/{id}")]
        public IActionResult EliminarProfesor(int id)
        {
            return Ok(_profesor.EliminarProfesor(id));
        }


    }
}
