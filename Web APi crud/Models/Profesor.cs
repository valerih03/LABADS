using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
namespace Web_APi_crud.Models
{
    [PrimaryKey("IdProfesor")]
    public class Profesor
    {
        public int IdProfesor { get; set; }
        [Required(ErrorMessage = "El nombre es requerido")]
        [MaxLength(50, ErrorMessage = "El nombre no puede tener mas de 50 caracteres")]
        public string Nombres { get; set; }
        [Required(ErrorMessage = "El apellido es requerido")]
        [MaxLength(50, ErrorMessage = "El nombre no puede tener mas de 50 caracteres")]
        public string Apellidos { get; set; }
        [Required(ErrorMessage = "El Email es requerido")]
        [EmailAddress(ErrorMessage = "El correo no es valido")]
        [MaxLength(254, ErrorMessage = "El correo no puede tener mas de 254 caracteres")]
        public string Email { get; set; }
    }
}
