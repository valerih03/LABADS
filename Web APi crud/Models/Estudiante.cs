using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
namespace Web_APi_crud.Models
{
    [PrimaryKey("idEstudiante")]
    public class Estudiante
    {
        public int idEstudiante { get; set; }
        [Required(ErrorMessage ="El nombre es requerido")]
        [MaxLength(50, ErrorMessage = "El nombre no puede tener mas de 50 caracteres")]
        public string nombre { get; set; }
        [Required(ErrorMessage = "El apellido es requerido")]
        [MaxLength(50, ErrorMessage = "El nombre no puede tener mas de 50 caracteres")]
        public string apellido { get; set; }
        [Required(ErrorMessage = "El codigo es requerido")]
        [MinLength(10, ErrorMessage = "El nombre no puede tener menos de 10 caracteres")]
        [MaxLength(length:12, ErrorMessage ="la longitud no puede ser mayor a 12 caracteres")]
        public string codigo { get; set; }
        [Required(ErrorMessage = "El crreo es requerido")]
        [EmailAddress(ErrorMessage = "El correo no es valido")]
        public string correo { get; set; }
    }
}
