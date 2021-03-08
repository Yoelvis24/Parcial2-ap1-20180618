using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parcial2_ap1_20180618.UI.Registros;
using Parcial2_ap1_20180618.UI.Consultas;

namespace Parcial2_ap1_20180618
{
    public partial class MenuInicio : Form
    {
        public MenuInicio()
        {
            InitializeComponent();
            //Registros
            this.rProyectosToolStripMenuItem.Click += new EventHandler(this.rProyectosToolStripMenuItem_ItemClicked);

            //Consultas
            this.cProyectosToolStripMenuItem.Click += new EventHandler(this.cProyectosToolStripMenuItem_ItemClicked);
        }

        private void cProyectosToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            var Proyectos = new ConsultarProyectos();
            Proyectos.MdiParent = this;
            Proyectos.Show();
        }

        private void rProyectosToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            var Proyectos = new RegistrarProyectos();
            Proyectos.MdiParent = this;
            Proyectos.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
