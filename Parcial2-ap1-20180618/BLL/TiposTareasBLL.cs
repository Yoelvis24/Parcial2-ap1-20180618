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
    public class TiposTareasBLL
    {
        public static bool Existe(string descripcion)
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

        private static bool Insertar(TiposTareas tiposTareas)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.TiposTareas.Add(tiposTareas);
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

        private static bool Modificar(TiposTareas tiposTareas)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Entry(tiposTareas).State = EntityState.Modified;
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
        
        public static bool Guardar(TiposTareas tiposTareas)
        {
            if (!Existe(tiposTareas.Descripcion))
                return Insertar(tiposTareas);
            else
                return Modificar(tiposTareas);
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                var tiposTareas = contexto.TiposTareas.Find(id);

                if(tiposTareas != null)
                {
                    contexto.TiposTareas.Remove(tiposTareas);
                    paso = contexto.SaveChanges() > 0;
                }
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

        public static TiposTareas Buscar(int id)
        {
            var contexto = new Contexto();
            var tiposTareas = new TiposTareas();

            try
            {
                tiposTareas = contexto.TiposTareas.Find(id);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return tiposTareas;
        }
        public static List<TiposTareas> GetList(Expression<Func<TiposTareas, bool>> criterio)
        {
            var lista = new List<TiposTareas>();
            Contexto contexto = new Contexto();

            try
            {
                lista = contexto.TiposTareas.Where(criterio).ToList();
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

        public static List<TiposTareas> GetTiposTareas()
        {
            List<TiposTareas> lista = new List<TiposTareas>();
            Contexto contexto = new Contexto();

            try
            {
                lista = contexto.TiposTareas.ToList();
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

        public static string BuscarRequerimiento(int id)
        {
            var contexto = new Contexto();
            var tiposTareas = new TiposTareas();

            try
            {
                tiposTareas = contexto.TiposTareas.Find(id);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return tiposTareas.Requerimiento;
        }

        public static string BuscarTiempo(int id)
        {
            var contexto = new Contexto();
            var tiposTareas = new TiposTareas();

            try
            {
                tiposTareas = contexto.TiposTareas.Find(id);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return Convert.ToString(tiposTareas.Tiempo);
        }
    }
}
