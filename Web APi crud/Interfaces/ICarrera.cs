using Web_APi_crud.Models;

namespace Web_APi_crud.Interfaces
{
    public interface ICarrera
    {
        public int AgregarCarrera(Carrera carrera);
        public int ActualizarCarrera(int id, Carrera carrera);
        public bool EliminarCarrera(int id);
        public List<Carrera> Carreras();
        public Carrera ConsultarCarrera(int id);
    }
}
