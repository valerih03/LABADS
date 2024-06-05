using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Web_APi_crud.Models
{
    [PrimaryKey("id")]
    public class Carrera
    {
        public int id { get; set; }
        [Required(ErrorMessage = "El nombre es requerido")]
        [MaxLength(40, ErrorMessage = "El nombre no puede tener mas de 40 caracteres con monas chinas")]
        public string nombre { get; set; }
        [Required(ErrorMessage = "El codigo es requerido")]
        [MaxLength(3, ErrorMessage = "El codigo no puede tener mas de 3 caracteres")]
        public string codigo { get; set; }
    }
}
