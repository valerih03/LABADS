using Microsoft.AspNetCore.Mvc;
using Web_APi_crud.Interfaces;
using Web_APi_crud.Models;

namespace Web_APi_crud.Controllers
{
    public class GrupoController : Controller
    {
       private readonly IGrupo _grupo;
        public GrupoController(IGrupo grupo)
        {
            _grupo = grupo;
        }
        [HttpGet("api/Grupos")]
        public IActionResult Grupos()
        {
            return Ok(_grupo.AllGrupos());
        }
        [HttpGet("api/Grupo/{id}")]
        public IActionResult ConsultarGrupo(int id)
        {
            return Ok(_grupo.ConsultarGrupo(id));
        }
        [HttpPost("api/AgregarGrupo")]
        public IActionResult AgregarGrupo([FromBody] Grupo grupo)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                return Ok(_grupo.AgregarGrupo(grupo));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("api/Grupo/{id}")]
        public IActionResult ActualizarGrupo(int id, [FromBody] Grupo grupo)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                return Ok(_grupo.ActualizarGrupo(id, grupo));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("api/Grupo/{id}")]
        public IActionResult EliminarGrupo(int id)
        {
            return Ok(_grupo.EliminarGrupo(id));
        }
    }
}
