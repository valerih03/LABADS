using Web_APi_crud.Interfaces;
using Web_APi_crud.Models;

namespace Web_APi_crud.Repositories
{
    public class CarreraRepository : ICarrera
    {
        //private List<Carrera> carreras = new List<Carrera>
        //    {
        //        new Carrera { id = 1, nombre = "Ingenieria en Sistemas Informaticos", codigo = "ISI" }
        //    };
        private readonly ApplicationDbContext applicationDbContext;

        public CarreraRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }
        public int AgregarCarrera(Carrera carrera)
        {
            try
            {
                //if(carreras != null)
                //{
                //    carrera.id = carreras.Last().id + 1;
                //}

                //carreras.Add(carrera);
                applicationDbContext.Carreras.Add(carrera);
                applicationDbContext.SaveChanges();
                return carrera.id;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int ActualizarCarrera(int id, Carrera carrera)
        {
            try
            {
                //int indice = carreras.FindIndex(e => e.id == id);
                //carreras[indice] = carrera;
                var item = applicationDbContext.Carreras.SingleOrDefault(e => e.id == id);
                applicationDbContext.Entry(item).CurrentValues.SetValues(carrera);
                applicationDbContext.SaveChanges();
                return id;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool EliminarCarrera(int id)
        {
            try
            {
                //int indice = carreras.FindIndex(e => e.id == id);
                //if (indice != -1)
                //{
                //    carreras.RemoveAt(indice);
                //    return true;
                //}
                //return false;
                var item = applicationDbContext.Carreras.SingleOrDefault(e => e.id == id);
                if (item != null)
                {
                    applicationDbContext.Carreras.Remove(item);
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

        public List<Carrera> Carreras()
        {
            try
            {
                //List<Carrera> resultado = carreras;
                //return resultado;
                return applicationDbContext.Carreras.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Carrera ConsultarCarrera(int id)
        {
            try
            {
                //Carrera resultado = carreras.Find(e => e.id == id);
                //return resultado;
                return applicationDbContext.Carreras.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
