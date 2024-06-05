using Microsoft.AspNetCore.Mvc;
using Web_APi_crud.Interfaces;
using Web_APi_crud.Models;

namespace Web_APi_crud.Controllers
{
    public class MateriaController : Controller
    {
        private readonly IMateria _materia;

        public MateriaController(IMateria materia)
        {
            _materia = materia;
        }

        [HttpGet("api/Materias")]
        public IActionResult Materias()
        {
            return Ok(_materia.Materias());
        }

        [HttpGet("api/Materia/{id}")]
        public IActionResult ConsultarMateria(int id)
        {
            return Ok(_materia.ConsultarMateria(id));
        }

        [HttpPost("api/AgregarMateria")]
        public IActionResult AgregarMateria([FromBody] Materia materia)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(_materia.AgregarMateria(materia));
        }

        [HttpPut("api/Materia/{id}")]
        public IActionResult ActualizarMateria(int id, [FromBody] Materia materia)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(_materia.ActualizarMateria(id, materia));
        }

        [HttpDelete("api/Materia/{id}")]
        public IActionResult EliminarMateria(int id)
        {
            return Ok(_materia.EliminarMateria(id));
        }
    }
}
