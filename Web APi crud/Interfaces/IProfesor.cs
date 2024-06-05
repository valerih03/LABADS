using Web_APi_crud.Models;

namespace Web_APi_crud.Interfaces
{
    public interface IProfesor
    {
       public List<Profesor> Profesores();
        public Profesor ConsultarProfesor(int id);
        public int AgregarProfesor(Profesor profesor);
        public int ActualizarProfesor(int id, Profesor profesor);
        public bool EliminarProfesor(int id);
    }
}
