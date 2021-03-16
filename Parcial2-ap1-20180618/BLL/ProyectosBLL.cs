using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parcial2_ap1_20180618.DAL;
using Parcial2_ap1_20180618.Entidades;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Parcial2_ap1_20180618.BLL
{
    public class ProyectosBLL
    {
        public static bool ExisteProyecto(string descripcion)
        {
            bool encontrado = false;
            Contexto contexto = new Contexto();

            try
            {
                encontrado = contexto.Proyectos.Any(e => e.Descripcion.ToLower() == descripcion.ToLower());
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return encontrado;
        }

        private static bool Insertar(Proyectos proyectos)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Proyectos.Add(proyectos);
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        private static bool Modificar(Proyectos proyectos)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Database.ExecuteSqlRaw($"Delete FROM ProyectosDetalle where ProyectoId = {proyectos.ProyectoId}");
                foreach(var anterior in proyectos.ProyectosDetalle)
                {
                    contexto.Entry(anterior).State = EntityState.Added;
                }
                contexto.Entry(proyectos).State = EntityState.Modified;
                paso = (contexto.SaveChanges() > 0);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        public static bool Guardar(Proyectos proyectos)
        {
            if (!ExisteProyecto(proyectos.Descripcion))
                return Insertar(proyectos);
            else
                return Modificar(proyectos);
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                var eliminar = contexto.Proyectos.Find(id);
                contexto.Entry(eliminar).State = EntityState.Deleted;

                paso = (contexto.SaveChanges() > 0);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }

        public static Proyectos Buscar(int id)
        {
            var contexto = new Contexto();
            var Proyectos = new Proyectos();

            try
            {
                Proyectos = contexto.Proyectos.Include(x => x.ProyectosDetalle).Where(p => p.ProyectoId == id).SingleOrDefault();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return Proyectos;
        }

        public static List<Proyectos> GetList(Expression<Func<Proyectos, bool>> criterio)
        {
            List<Proyectos> Lista = new List<Proyectos>();
            Contexto contexto = new Contexto();

            try
            {
                //Se obtiene la lista y se filtra de acuerdo al criterio que recibe esta función
                Lista = contexto.Proyectos.Where(criterio).ToList();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return Lista;
        }

        public static List<Proyectos> GetProyectos()
        {
            List<Proyectos> lista = new List<Proyectos>();
            Contexto contexto = new Contexto();

            try
            {
                lista = contexto.Proyectos.ToList();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return lista;
        }
    }
}
