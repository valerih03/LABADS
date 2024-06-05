using Web_APi_crud.Models;

namespace Web_APi_crud.Interfaces
{
    public interface IMateria
    {
        public int AgregarMateria(Materia materia);
        public int ActualizarMateria(int id, Materia materia);
        public bool EliminarMateria(int id);
        public List<Materia> Materias();
        public Materia ConsultarMateria(int id);
    }
}
