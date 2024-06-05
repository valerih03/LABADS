using Web_APi_crud.Interfaces;
using Web_APi_crud.Models;

namespace Web_APi_crud.Repositories
{
    public class MateriaRepository : IMateria
    {
        //private List<Materia> materias = new List<Materia>
        //{
        //    new Materia {idMateria = 1, nombre = "Matematicas"},
        //};
        private readonly ApplicationDbContext applicationDbContext;

        public MateriaRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }
        public int AgregarMateria(Materia materia)
        {
            try
            {
                //materias.Add(materia);
                //return 1;
                applicationDbContext.Materias.Add(materia);
                applicationDbContext.SaveChanges();
                return materia.idMateria;
            }
            catch (Exception)
            {
               throw;
            }
        }

        public int ActualizarMateria(int id, Materia materia)
        {
            try
            {
                //int indice = materias.FindIndex(e => e.idMateria == id);
                //materias[indice] = materia;
                //return id;
                var item = applicationDbContext.Materias.SingleOrDefault(e => e.idMateria == id);
                applicationDbContext.Entry(item).CurrentValues.SetValues(materia);
                applicationDbContext.SaveChanges();
                return id;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool EliminarMateria(int id)
        {
           try
            {
                //int indice = materias.FindIndex(e => e.idMateria == id);
                //if (indice != -1)
                //{
                //     materias.RemoveAt(indice);
                //     return true;
                //}
                //return false;
                var item = applicationDbContext.Materias.SingleOrDefault(e => e.idMateria == id);
                if (item != null)
                {
                    applicationDbContext.Materias.Remove(item);
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

        public List<Materia> Materias()
        {
           try
            {
                //return materias;
                return applicationDbContext.Materias.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Materia ConsultarMateria(int id)
        {
            try
            {
                //Materia materia = materias.Find(e => e.idMateria == id);
                //return materia;
                return applicationDbContext.Materias.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
