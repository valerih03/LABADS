using Microsoft.AspNetCore.Mvc;
using Web_APi_crud.Interfaces;
using Web_APi_crud.Models;


namespace Web_APi_crud.Controllers
{
    [Route("api/estudiantes/")]
    public class EstudianteController : ControllerBase
    {
        private readonly IEstudiante estudiante;
        private const string COD_EXITO = "000000";
        private const string COD_ERROR = "999999";
        private string pCodRespuesta;
        private string pMensajeUsuario;
        private string pMensajeTecnico;

        public EstudianteController(IEstudiante estudiante)
        {
            this.estudiante = estudiante;
        }

        [HttpPost("agregarEstudiante")]
        public IActionResult AgregarEstudiante([FromBody] Estudiante estudiante)
        {
            try
            {
                // Validar el modelo
                if(!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                int resultado = this.estudiante.AgregarEstudiante(estudiante);
                if (resultado > 0)
                {
                    pCodRespuesta = COD_EXITO;
                    pMensajeUsuario = "Estudiante agregado correctamente";
                    pMensajeTecnico = pCodRespuesta + " || " + pMensajeUsuario;
                }
                else
                {
                    pCodRespuesta = COD_ERROR;
                    pMensajeUsuario = "Error al agregar estudiante";
                    pMensajeTecnico = pCodRespuesta + " || " + pMensajeUsuario;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return Ok(new
            {
                codRespuesta = pCodRespuesta,
                mensajeUsuario = pMensajeUsuario,
                mensajeTecnico = pMensajeTecnico
            });
        }

        [HttpPost("actualizarEstudiante/{id}")]
         public IActionResult ActualizarEstudiante(int id, [FromBody] Estudiante estudiante)
        {
            try
            {
                // Validar el modelo
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                int resultado = this.estudiante.ActualizarEstudiante(id, estudiante);
                if (resultado > 0)
                {
                    pCodRespuesta = COD_EXITO;
                    pMensajeUsuario = "Estudiante actualizado correctamente";
                    pMensajeTecnico = pCodRespuesta + " || " + pMensajeUsuario;
                }
                else
                {
                    pCodRespuesta = COD_ERROR;
                    pMensajeUsuario = "Error al actualizar estudiante";
                    pMensajeTecnico = pCodRespuesta + " || " + pMensajeUsuario;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return Ok(new
            {
                codRespuesta = pCodRespuesta,
                mensajeUsuario = pMensajeUsuario,
                mensajeTecnico = pMensajeTecnico
            });
        
         }

        [HttpDelete("eliminarEstudiante/{id}")]
        public IActionResult EliminarEstudiante(int id)
        {
            try
            {
                bool resultado = this.estudiante.EliminarEstudiante(id);
                if (resultado)
                {
                    pCodRespuesta = COD_EXITO;
                    pMensajeUsuario = "Estudiante eliminado correctamente";
                    pMensajeTecnico = pCodRespuesta + " || " + pMensajeUsuario;
                }
                else
                {
                    pCodRespuesta = COD_ERROR;
                    pMensajeUsuario = "Error al eliminar estudiante";
                    pMensajeTecnico = pCodRespuesta + " || " + pMensajeUsuario;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return Ok(new
            {
                codRespuesta = pCodRespuesta,
                mensajeUsuario = pMensajeUsuario,
                mensajeTecnico = pMensajeTecnico
            });
        }

        [HttpGet("consultarEstudiante/{id}")]
        public IActionResult ConsultarEstudiante(int id)
        {
            try
            {
                Estudiante resultado = this.estudiante.ConsultarEstudiante(id);
                if (resultado != null)
                {
                    pCodRespuesta = COD_EXITO;
                    pMensajeUsuario = "Estudiante consultado correctamente";
                    pMensajeTecnico = pCodRespuesta + " || " + pMensajeUsuario;
                }
                else
                {
                    pCodRespuesta = COD_ERROR;
                    pMensajeUsuario = "Error al consultar estudiante";
                    pMensajeTecnico = pCodRespuesta + " || " + pMensajeUsuario;
                }
                return Ok(new
                {
                    codRespuesta = pCodRespuesta,
                    mensajeUsuario = pMensajeUsuario,
                    mensajeTecnico = pMensajeTecnico,
                    resultado = resultado
                });
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet("estudiantes")]
        public IActionResult Estudiantes()
        {
            try
            {
              List<Estudiante> resultado = this.estudiante.Estudiantes();
              return Ok(resultado);
             
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
