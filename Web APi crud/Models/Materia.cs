using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
namespace Web_APi_crud.Models
{
    [PrimaryKey("idMateria")]
    public class Materia
    {
        public int idMateria { get; set; }
        [Required(ErrorMessage = "El nombre es requerido")]
        [MaxLength(50, ErrorMessage = "El nombre no puede tener mas de 50 caracteres")]
        public string nombre { get; set; }
    }
}
