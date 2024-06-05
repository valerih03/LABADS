using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
namespace Web_APi_crud.Models
{
    [PrimaryKey("idGrupo")]
    public class Grupo
    {
        public int idGrupo { get; set; }
        [Required(ErrorMessage = "El idCarrera es requerido")]
        public int idCarrera { get; set; }
        [Required(ErrorMessage = "El idMateria es requerido")]
        public int idMateria { get; set; }
        [Required(ErrorMessage = "El idProfesor es requerido")]
        public int idProfesor { get; set; }
        [Required(ErrorMessage = "El ciclo es requerido")]
        public int Ciclo { get; set; }
        [Required(ErrorMessage = "El año es requerido")]
        public int Annio { get; set; }
    }
}
