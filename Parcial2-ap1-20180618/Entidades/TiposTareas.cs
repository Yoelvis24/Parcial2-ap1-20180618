using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Parcial2_ap1_20180618.Entidades
{
    public class TiposTareas
    {
        [Key]
        public int TipoId { get; set; }
        public string Descripcion { get; set; }
        public string Requerimiento { get; set; }
        public int Tiempo { get; set; }
        public TiposTareas()
        {
            TipoId = 0;
            Descripcion = "";
            Requerimiento = "";
            Tiempo = 0;
        }

        public TiposTareas(int id, string descripcion, string requerimiento, int tiempo)
        {
            TipoId = id;
            Descripcion = descripcion;
            Requerimiento = requerimiento;
            Tiempo = tiempo;
        }
    }
}
