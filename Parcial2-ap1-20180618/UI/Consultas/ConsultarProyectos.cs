using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parcial2_ap1_20180618.Entidades;
using Parcial2_ap1_20180618.BLL;

namespace Parcial2_ap1_20180618.UI.Consultas
{
    public partial class ConsultarProyectos : Form
    {
        public ConsultarProyectos()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            var lista = new List<Proyectos>();

            //Condición cuando el criterio no está vacío
            if (!String.IsNullOrWhiteSpace(CriterioTextBox.Text))
            {
                switch (FiltroComboBox.SelectedIndex)
                {
                    case 0:
                        lista = ProyectosBLL.GetList(r => r.ProyectoId == Utilidades.ToInt(CriterioTextBox.Text));
                        break;
                    case 1:
                        lista = ProyectosBLL.GetList(r => r.Descripcion.Contains(CriterioTextBox.Text));
                        break;
                    case 2:
                        lista = ProyectosBLL.GetList(r => r.TiempoTotal == Utilidades.ToInt(CriterioTextBox.Text));
                        break;
                    default:
                        break;
                }
            }
            else
                lista = ProyectosBLL.GetList(r => true);

            ConsultarProyectosDataGridView.DataSource = null;
            ConsultarProyectosDataGridView.DataSource = lista;
        }
    }
}
