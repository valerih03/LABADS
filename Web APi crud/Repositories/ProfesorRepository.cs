using Web_APi_crud.Interfaces;
using Web_APi_crud.Models;

namespace Web_APi_crud.Repositories
{
    public class ProfesorRepository : IProfesor
    {
        //private List<Profesor> profesores = new List<Profesor>
        //{
        //        new Profesor { IdProfesor = 1, Nombres = "Juan", Apellidos = "Perez", Email = ""}
        //};
        private readonly ApplicationDbContext applicationDbContext;

        public ProfesorRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        public int AgregarProfesor(Profesor profesor)
        {
            try
            {
                //if (profesores != null)
                //{
                //    profesor.IdProfesor = profesores.Last().IdProfesor + 1;
                //}

                //profesores.Add(profesor);
                //return profesor.IdProfesor;
                applicationDbContext.Profesores.Add(profesor);
                applicationDbContext.SaveChanges();
                return profesor.IdProfesor;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int ActualizarProfesor(int id, Profesor profesor)
        {
            try
            {
                //int indice = profesores.FindIndex(e => e.IdProfesor == id);
                //profesores[indice] = profesor;
                //return id;
                var item = applicationDbContext.Profesores.SingleOrDefault(e => e.IdProfesor == id);
                applicationDbContext.Entry(item).CurrentValues.SetValues(profesor);
                applicationDbContext.SaveChanges();
                return id;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool EliminarProfesor(int id)
        {
            try
            {
                //int indice = profesores.FindIndex(e => e.IdProfesor == id);
                //if (indice != -1)
                //{
                //    profesores.RemoveAt(indice);
                //    return true;
                //}
                //return false;
                var item = applicationDbContext.Profesores.SingleOrDefault(e => e.IdProfesor == id);
                if (item != null)
                {
                    applicationDbContext.Profesores.Remove(item);
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

        public List<Profesor> Profesores()
        {
            //return profesores;
            return applicationDbContext.Profesores.ToList();
        }

        public Profesor ConsultarProfesor(int id)
        {
            //return profesores.FirstOrDefault(e => e.IdProfesor == id);
            return applicationDbContext.Profesores.FirstOrDefault(e => e.IdProfesor == id);
        }
    }
}
