using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Parcial2_ap1_20180618.Entidades
{
    public class Proyectos
    {
        [Key]
        public int ProyectoId { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public int TiempoTotal { get; set; }

        [ForeignKey("ProyectoId")]
        public List<ProyectosDetalle> ProyectosDetalle { get; set; }
        public Proyectos()
        {
            ProyectoId = 0;
            Fecha = DateTime.Now;
            Descripcion = string.Empty;
            TiempoTotal = 0;
            ProyectosDetalle = new List<ProyectosDetalle>();
        }

        public Proyectos(int proyectoId, DateTime fecha, string descripcion, int tiempoTotal)
        {
            ProyectoId = proyectoId;
            Fecha = fecha;
            Descripcion = descripcion;
            TiempoTotal = tiempoTotal;
            ProyectosDetalle = new List<ProyectosDetalle>();
        }
    }
}
