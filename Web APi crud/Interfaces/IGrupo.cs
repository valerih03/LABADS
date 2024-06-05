using Web_APi_crud.Models;

namespace Web_APi_crud.Interfaces
{
    public interface IGrupo
    {
       public int AgregarGrupo(Grupo grupo);
        public int ActualizarGrupo(int id, Grupo grupo);
        public bool EliminarGrupo(int id);
        public List<Grupo> AllGrupos();
        public Grupo ConsultarGrupo(int id);
    }
}
