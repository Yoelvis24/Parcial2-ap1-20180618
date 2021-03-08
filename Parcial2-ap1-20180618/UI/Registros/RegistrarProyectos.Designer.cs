
namespace Parcial2_ap1_20180618.UI.Registros
{
    partial class RegistrarProyectos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarProyectos));
            this.ProyectoIdLabel = new System.Windows.Forms.Label();
            this.FechaLabel = new System.Windows.Forms.Label();
            this.DescripcionLabel = new System.Windows.Forms.Label();
            this.FechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DescripcionTextBox = new System.Windows.Forms.TextBox();
            this.DetalleGroupBox = new System.Windows.Forms.GroupBox();
            this.RemoverButton = new System.Windows.Forms.Button();
            this.ProyectoDetalleDataGridView = new System.Windows.Forms.DataGridView();
            this.TiempoTextBox = new System.Windows.Forms.TextBox();
            this.RequerimientoTextBox = new System.Windows.Forms.TextBox();
            this.TiposTareasComboBox = new System.Windows.Forms.ComboBox();
            this.AgregarButton = new System.Windows.Forms.Button();
            this.TiempoLabel = new System.Windows.Forms.Label();
            this.RequerimientoLabel = new System.Windows.Forms.Label();
            this.TipoTareaLabel = new System.Windows.Forms.Label();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.TiempoTotalLabel = new System.Windows.Forms.Label();
            this.TiempoTotalListBox = new System.Windows.Forms.ListBox();
            this.ProyectoIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ProyectoErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.DetalleGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProyectoDetalleDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProyectoIdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProyectoErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // ProyectoIdLabel
            // 
            this.ProyectoIdLabel.AutoSize = true;
            this.ProyectoIdLabel.Location = new System.Drawing.Point(10, 11);
            this.ProyectoIdLabel.Name = "ProyectoIdLabel";
            this.ProyectoIdLabel.Size = new System.Drawing.Size(67, 15);
            this.ProyectoIdLabel.TabIndex = 0;
            this.ProyectoIdLabel.Text = "Proyecto Id";
            // 
            // FechaLabel
            // 
            this.FechaLabel.AutoSize = true;
            this.FechaLabel.Location = new System.Drawing.Point(12, 64);
            this.FechaLabel.Name = "FechaLabel";
            this.FechaLabel.Size = new System.Drawing.Size(38, 15);
            this.FechaLabel.TabIndex = 1;
            this.FechaLabel.Text = "Fecha";
            // 
            // DescripcionLabel
            // 
            this.DescripcionLabel.AutoSize = true;
            this.DescripcionLabel.Location = new System.Drawing.Point(10, 119);
            this.DescripcionLabel.Name = "DescripcionLabel";
            this.DescripcionLabel.Size = new System.Drawing.Size(138, 15);
            this.DescripcionLabel.TabIndex = 2;
            this.DescripcionLabel.Text = "Descripción del Proyecto";
            // 
            // FechaDateTimePicker
            // 
            this.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaDateTimePicker.Location = new System.Drawing.Point(12, 82);
            this.FechaDateTimePicker.Name = "FechaDateTimePicker";
            this.FechaDateTimePicker.Size = new System.Drawing.Size(136, 23);
            this.FechaDateTimePicker.TabIndex = 4;
            // 
            // DescripcionTextBox
            // 
            this.DescripcionTextBox.Location = new System.Drawing.Point(12, 137);
            this.DescripcionTextBox.Multiline = true;
            this.DescripcionTextBox.Name = "DescripcionTextBox";
            this.DescripcionTextBox.Size = new System.Drawing.Size(587, 68);
            this.DescripcionTextBox.TabIndex = 5;
            // 
            // DetalleGroupBox
            // 
            this.DetalleGroupBox.Controls.Add(this.RemoverButton);
            this.DetalleGroupBox.Controls.Add(this.ProyectoDetalleDataGridView);
            this.DetalleGroupBox.Controls.Add(this.TiempoTextBox);
            this.DetalleGroupBox.Controls.Add(this.RequerimientoTextBox);
            this.DetalleGroupBox.Controls.Add(this.TiposTareasComboBox);
            this.DetalleGroupBox.Controls.Add(this.AgregarButton);
            this.DetalleGroupBox.Controls.Add(this.TiempoLabel);
            this.DetalleGroupBox.Controls.Add(this.RequerimientoLabel);
            this.DetalleGroupBox.Controls.Add(this.TipoTareaLabel);
            this.DetalleGroupBox.Location = new System.Drawing.Point(12, 211);
            this.DetalleGroupBox.Name = "DetalleGroupBox";
            this.DetalleGroupBox.Size = new System.Drawing.Size(587, 300);
            this.DetalleGroupBox.TabIndex = 6;
            this.DetalleGroupBox.TabStop = false;
            this.DetalleGroupBox.Text = "Detalle de tareas a realizar";
            // 
            // RemoverButton
            // 
            this.RemoverButton.Image = ((System.Drawing.Image)(resources.GetObject("RemoverButton.Image")));
            this.RemoverButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RemoverButton.Location = new System.Drawing.Point(6, 257);
            this.RemoverButton.Name = "RemoverButton";
            this.RemoverButton.Size = new System.Drawing.Size(106, 37);
            this.RemoverButton.TabIndex = 8;
            this.RemoverButton.Text = "Remover Fila";
            this.RemoverButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RemoverButton.UseVisualStyleBackColor = true;
            this.RemoverButton.Click += new System.EventHandler(this.RemoverButton_Click);
            // 
            // ProyectoDetalleDataGridView
            // 
            this.ProyectoDetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProyectoDetalleDataGridView.Location = new System.Drawing.Point(6, 78);
            this.ProyectoDetalleDataGridView.Name = "ProyectoDetalleDataGridView";
            this.ProyectoDetalleDataGridView.RowHeadersWidth = 51;
            this.ProyectoDetalleDataGridView.RowTemplate.Height = 25;
            this.ProyectoDetalleDataGridView.Size = new System.Drawing.Size(575, 173);
            this.ProyectoDetalleDataGridView.TabIndex = 7;
            // 
            // TiempoTextBox
            // 
            this.TiempoTextBox.Location = new System.Drawing.Point(393, 49);
            this.TiempoTextBox.Name = "TiempoTextBox";
            this.TiempoTextBox.Size = new System.Drawing.Size(102, 23);
            this.TiempoTextBox.TabIndex = 6;
            // 
            // RequerimientoTextBox
            // 
            this.RequerimientoTextBox.Location = new System.Drawing.Point(133, 49);
            this.RequerimientoTextBox.Name = "RequerimientoTextBox";
            this.RequerimientoTextBox.Size = new System.Drawing.Size(254, 23);
            this.RequerimientoTextBox.TabIndex = 5;
            // 
            // TiposTareasComboBox
            // 
            this.TiposTareasComboBox.FormattingEnabled = true;
            this.TiposTareasComboBox.Location = new System.Drawing.Point(6, 49);
            this.TiposTareasComboBox.Name = "TiposTareasComboBox";
            this.TiposTareasComboBox.Size = new System.Drawing.Size(121, 23);
            this.TiposTareasComboBox.TabIndex = 4;
            this.TiposTareasComboBox.SelectedIndexChanged += new System.EventHandler(this.TiposTareasComboBox_SelectedIndexChanged);
            // 
            // AgregarButton
            // 
            this.AgregarButton.Image = ((System.Drawing.Image)(resources.GetObject("AgregarButton.Image")));
            this.AgregarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AgregarButton.Location = new System.Drawing.Point(501, 48);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(80, 24);
            this.AgregarButton.TabIndex = 3;
            this.AgregarButton.Text = "Agregar";
            this.AgregarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AgregarButton.UseVisualStyleBackColor = true;
            this.AgregarButton.Click += new System.EventHandler(this.AgregarButton_Click);
            // 
            // TiempoLabel
            // 
            this.TiempoLabel.AutoSize = true;
            this.TiempoLabel.Location = new System.Drawing.Point(393, 31);
            this.TiempoLabel.Name = "TiempoLabel";
            this.TiempoLabel.Size = new System.Drawing.Size(102, 15);
            this.TiempoLabel.TabIndex = 2;
            this.TiempoLabel.Text = "Tiempo (minutos)";
            // 
            // RequerimientoLabel
            // 
            this.RequerimientoLabel.AutoSize = true;
            this.RequerimientoLabel.Location = new System.Drawing.Point(133, 31);
            this.RequerimientoLabel.Name = "RequerimientoLabel";
            this.RequerimientoLabel.Size = new System.Drawing.Size(142, 15);
            this.RequerimientoLabel.TabIndex = 1;
            this.RequerimientoLabel.Text = "Requerimiento de la tarea";
            // 
            // TipoTareaLabel
            // 
            this.TipoTareaLabel.AutoSize = true;
            this.TipoTareaLabel.Location = new System.Drawing.Point(6, 31);
            this.TipoTareaLabel.Name = "TipoTareaLabel";
            this.TipoTareaLabel.Size = new System.Drawing.Size(80, 15);
            this.TipoTareaLabel.TabIndex = 0;
            this.TipoTareaLabel.Text = "Tipos de tarea";
            // 
            // BuscarButton
            // 
            this.BuscarButton.Image = ((System.Drawing.Image)(resources.GetObject("BuscarButton.Image")));
            this.BuscarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuscarButton.Location = new System.Drawing.Point(154, 28);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(68, 24);
            this.BuscarButton.TabIndex = 7;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.Image = ((System.Drawing.Image)(resources.GetObject("NuevoButton.Image")));
            this.NuevoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NuevoButton.Location = new System.Drawing.Point(17, 517);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(96, 42);
            this.NuevoButton.TabIndex = 8;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Image = ((System.Drawing.Image)(resources.GetObject("GuardarButton.Image")));
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GuardarButton.Location = new System.Drawing.Point(135, 517);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(96, 42);
            this.GuardarButton.TabIndex = 9;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Image = ((System.Drawing.Image)(resources.GetObject("EliminarButton.Image")));
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EliminarButton.Location = new System.Drawing.Point(251, 517);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(96, 42);
            this.EliminarButton.TabIndex = 10;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // TiempoTotalLabel
            // 
            this.TiempoTotalLabel.AutoSize = true;
            this.TiempoTotalLabel.Location = new System.Drawing.Point(437, 533);
            this.TiempoTotalLabel.Name = "TiempoTotalLabel";
            this.TiempoTotalLabel.Size = new System.Drawing.Size(75, 15);
            this.TiempoTotalLabel.TabIndex = 11;
            this.TiempoTotalLabel.Text = "Tiempo Total";
            // 
            // TiempoTotalListBox
            // 
            this.TiempoTotalListBox.FormattingEnabled = true;
            this.TiempoTotalListBox.ItemHeight = 15;
            this.TiempoTotalListBox.Location = new System.Drawing.Point(513, 529);
            this.TiempoTotalListBox.Name = "TiempoTotalListBox";
            this.TiempoTotalListBox.Size = new System.Drawing.Size(86, 19);
            this.TiempoTotalListBox.TabIndex = 12;
            // 
            // ProyectoIdNumericUpDown
            // 
            this.ProyectoIdNumericUpDown.Location = new System.Drawing.Point(12, 28);
            this.ProyectoIdNumericUpDown.Name = "ProyectoIdNumericUpDown";
            this.ProyectoIdNumericUpDown.Size = new System.Drawing.Size(136, 23);
            this.ProyectoIdNumericUpDown.TabIndex = 13;
            // 
            // ProyectoErrorProvider
            // 
            this.ProyectoErrorProvider.ContainerControl = this;
            // 
            // RegistrarProyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 571);
            this.Controls.Add(this.ProyectoIdNumericUpDown);
            this.Controls.Add(this.TiempoTotalListBox);
            this.Controls.Add(this.TiempoTotalLabel);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.DetalleGroupBox);
            this.Controls.Add(this.DescripcionTextBox);
            this.Controls.Add(this.FechaDateTimePicker);
            this.Controls.Add(this.DescripcionLabel);
            this.Controls.Add(this.FechaLabel);
            this.Controls.Add(this.ProyectoIdLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistrarProyectos";
            this.Text = "Registro de Proyectos";
            this.Load += new System.EventHandler(this.RegistrarProyectos_Load);
            this.DetalleGroupBox.ResumeLayout(false);
            this.DetalleGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProyectoDetalleDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProyectoIdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProyectoErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProyectoIdLabel;
        private System.Windows.Forms.Label FechaLabel;
        private System.Windows.Forms.Label DescripcionLabel;
        private System.Windows.Forms.DateTimePicker FechaDateTimePicker;
        private System.Windows.Forms.TextBox DescripcionTextBox;
        private System.Windows.Forms.GroupBox DetalleGroupBox;
        private System.Windows.Forms.Button RemoverButton;
        private System.Windows.Forms.DataGridView ProyectoDetalleDataGridView;
        private System.Windows.Forms.TextBox TiempoTextBox;
        private System.Windows.Forms.TextBox RequerimientoTextBox;
        private System.Windows.Forms.ComboBox TiposTareasComboBox;
        private System.Windows.Forms.Button AgregarButton;
        private System.Windows.Forms.Label TiempoLabel;
        private System.Windows.Forms.Label RequerimientoLabel;
        private System.Windows.Forms.Label TipoTareaLabel;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Label TiempoTotalLabel;
        private System.Windows.Forms.ListBox TiempoTotalListBox;
        private System.Windows.Forms.NumericUpDown ProyectoIdNumericUpDown;
        private System.Windows.Forms.ErrorProvider ProyectoErrorProvider;
    }
}