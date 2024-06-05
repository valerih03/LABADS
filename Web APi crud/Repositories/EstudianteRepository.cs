using System.Linq;
using Web_APi_crud.Interfaces;
using Web_APi_crud.Models;

namespace Web_APi_crud.Repositories
{
    public class EstudianteRepository : IEstudiante
    {
        //private List<Estudiante> estudiantes = new List<Estudiante>
        //{
        //    new Estudiante { idEstudiante = 1, nombre = "Juan", apellido = "Perez", codigo = "001", correo = "001@usonsonate.edu.sv"}
        //};
        private readonly ApplicationDbContext applicationDbContext;

        public EstudianteRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }
        public int AgregarEstudiante(Estudiante estudiante)
        {
            try
            {
                //if(estudiantes != null)
                //{
                //    estudiante.idEstudiante = estudiantes.Last().idEstudiante + 1;
                //}

                //estudiantes.Add(estudiante);
                applicationDbContext.Estudiantes.Add(estudiante);
                applicationDbContext.SaveChanges();
                return estudiante.idEstudiante;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int ActualizarEstudiante(int id, Estudiante estudiante)
        {
            try
            {
                //int indice = estudiantes.FindIndex(e => e.idEstudiante == id);
                //estudiantes[indice] = estudiante;
                var item = applicationDbContext.Estudiantes.SingleOrDefault(e => e.idEstudiante == id);
                applicationDbContext.Entry(item).CurrentValues.SetValues(estudiante);
                applicationDbContext.SaveChanges();
                return id;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool EliminarEstudiante(int id)
        {
            try
            {
                //int indice = estudiantes.FindIndex(e => e.idEstudiante == id);
                //if (indice != -1)
                //{
                //    estudiantes.RemoveAt(indice);
                //    return true;
                //}
                //return false;
                var item = applicationDbContext.Estudiantes.SingleOrDefault(e => e.idEstudiante == id);
                if (item != null)
                {
                    applicationDbContext.Estudiantes.Remove(item);
                    applicationDbContext.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Estudiante> Estudiantes()
        {
            try
            {
                //return estudiantes;
                return applicationDbContext.Estudiantes.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Estudiante ConsultarEstudiante(int id)
        {
            try
            {
                //return estudiantes.Find(e => e.idEstudiante == id);

                return applicationDbContext.Estudiantes.SingleOrDefault(e => e.idEstudiante == id);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
