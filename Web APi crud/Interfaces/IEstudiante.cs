using Web_APi_crud.Models;

namespace Web_APi_crud.Interfaces
{
    public interface IEstudiante
    {
        public int AgregarEstudiante(Estudiante estudiante);
        public int ActualizarEstudiante(int id,Estudiante estudiante);
        public bool EliminarEstudiante(int id);
        public List<Estudiante> Estudiantes();
        public Estudiante ConsultarEstudiante(int id);
    }
}
