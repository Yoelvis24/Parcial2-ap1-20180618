using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Parcial2_ap1_20180618.DAL;
using Parcial2_ap1_20180618.Entidades;
using Parcial2_ap1_20180618.BLL;

namespace Parcial2_ap1_20180618.UI.Registros
{
    public partial class RegistrarProyectos : Form
    {
        public List<ProyectosDetalle> Detalle { get; set; }
        
        public RegistrarProyectos()
        {
            InitializeComponent();
            this.Detalle = new List<ProyectosDetalle>();
        }
        
        private void CargarGrid()
        {
            RegistrarProyectoDetalleDataGridView.DataSource = null;
            RegistrarProyectoDetalleDataGridView.DataSource = this.Detalle;
        }

        private void Limpiar()
        {
            ProyectoIdNumericUpDown.Value = 0;
            DescripcionTextBox.Clear();
            FechaDateTimePicker.Value = DateTime.Now;
            TiempoTotalListBox.Items.Clear();
            ProyectoErrorProvider.Clear();

            this.Detalle = new List<ProyectosDetalle>();
            CargarGrid();
        }

        private bool Validar()
        {
            bool paso = true;

            if(DescripcionTextBox.Text == "")
            {
                ProyectoErrorProvider.SetError(DescripcionTextBox, "Campo obligatorio");
                DescripcionTextBox.Focus();
                paso = false;
            }
            if(ProyectosBLL.ExisteProyecto(DescripcionTextBox.Text))
            {
                ProyectoErrorProvider.SetError(DescripcionTextBox, "Este proyecto ya existe");
                DescripcionTextBox.Focus();
                paso = false;
            }
            if(this.Detalle.Count == 0)
            {
                ProyectoErrorProvider.SetError(RegistrarProyectoDetalleDataGridView, "Debe seleccionar el tipo de tarea");
                TiposTareasComboBox.Focus();
                paso = false;
            }

            return paso;
        }

        private Proyectos LlenaClase()
        {
            Proyectos proyectos = new Proyectos();
            proyectos.ProyectoId = (int)ProyectoIdNumericUpDown.Value;
            proyectos.Descripcion = DescripcionTextBox.Text;
            proyectos.Fecha = FechaDateTimePicker.Value;
            proyectos.TiempoTotal += Convert.ToInt32(TiempoTextBox.Text);

            proyectos.ProyectosDetalle = this.Detalle;
            return proyectos;
        }

        private void LlenaCampos(Proyectos proyectos)
        {
            ProyectoIdNumericUpDown.Value = proyectos.ProyectoId;
            DescripcionTextBox.Text = proyectos.Descripcion;
            FechaDateTimePicker.Value = proyectos.Fecha;
            TiempoTotalListBox.Items.Add(proyectos.TiempoTotal);

            this.Detalle = proyectos.ProyectosDetalle;
            CargarGrid();
        }

        private bool ExisteEnBaseDeDatos()
        {
            var proyectos = new Proyectos();
            proyectos = ProyectosBLL.Buscar((int)ProyectoIdNumericUpDown.Value);
            return (proyectos != null);
        }
        private void RegistrarProyectos_Load(object sender, EventArgs e)
        {
            TiposTareasComboBox.DataSource = TiposTareasBLL.GetTiposTareas();
            TiposTareasComboBox.DisplayMember = "Descripcion";
            TiposTareasComboBox.ValueMember = "TipoId";
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            Proyectos proyectos = new Proyectos();
            int id = (int)ProyectoIdNumericUpDown.Value;

            Limpiar();
            proyectos = ProyectosBLL.Buscar(id);


            if(proyectos != null)
            {
                LlenaCampos(proyectos);
            }
            else
            {
                MessageBox.Show("Proyecto no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            if (RegistrarProyectoDetalleDataGridView.DataSource != null)
                this.Detalle = (List<ProyectosDetalle>)RegistrarProyectoDetalleDataGridView.DataSource;

            this.Detalle.Add(
                new ProyectosDetalle(
                    proyectoDetalleId: 0,
                    proyectoId: (int)ProyectoIdNumericUpDown.Value,
                    tipoTareaId: Convert.ToInt32(TiposTareasComboBox.SelectedIndex) + 1,
                    requerimiento: RequerimientoTextBox.Text,
                    tiempo: Convert.ToInt32(TiempoTextBox.Text)
                )
            );
            CargarGrid();
            TiposTareasComboBox.Focus();
        }

        private void RemoverButton_Click(object sender, EventArgs e)
        {
            if((RegistrarProyectoDetalleDataGridView.Rows.Count > 0) && RegistrarProyectoDetalleDataGridView.CurrentRow != null)
            {
                Detalle.RemoveAt(RegistrarProyectoDetalleDataGridView.CurrentRow.Index);
                CargarGrid();
            }
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Proyectos proyectos;

            if (!Validar())
                return;

            proyectos = LlenaClase();
            var paso = ProyectosBLL.Guardar(proyectos);
            if(paso)
            {
                Limpiar();
                MessageBox.Show("El Proyecto ha sido guardado", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Error al guardar proyecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            int id = (int)ProyectoIdNumericUpDown.Value;
            ProyectoErrorProvider.Clear();

            if ((int)ProyectoIdNumericUpDown.Value == 0)
            {
                MessageBox.Show("Proyecto no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ProyectosBLL.Eliminar(id))
            {
                MessageBox.Show("El Proyecto ha sido eliminado", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
                ProyectoErrorProvider.SetError(ProyectoIdNumericUpDown, "Id inexistente");
        }

        private void TiposTareasComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           if(TiposTareasComboBox.SelectedIndex == 0)
            {
                RequerimientoTextBox.Text = TiposTareasBLL.BuscarRequerimiento(1);
                TiempoTextBox.Text = Convert.ToString(TiposTareasBLL.BuscarTiempo(1));
            }
            if (TiposTareasComboBox.SelectedIndex == 1)
            {
                RequerimientoTextBox.Text = TiposTareasBLL.BuscarRequerimiento(2);
                TiempoTextBox.Text = Convert.ToString(TiposTareasBLL.BuscarTiempo(2));
            }
            if (TiposTareasComboBox.SelectedIndex == 2)
            {
                RequerimientoTextBox.Text = TiposTareasBLL.BuscarRequerimiento(3);
                TiempoTextBox.Text = Convert.ToString(TiposTareasBLL.BuscarTiempo(3));
            }
            if (TiposTareasComboBox.SelectedIndex == 3)
            {
                RequerimientoTextBox.Text = TiposTareasBLL.BuscarRequerimiento(4);
                TiempoTextBox.Text = Convert.ToString(TiposTareasBLL.BuscarTiempo(4));
            }
        }
    }
}
