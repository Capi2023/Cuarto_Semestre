
namespace clinica
{
    partial class frmReporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporte));
            this.lbltitReporte = new System.Windows.Forms.Label();
            this.lblNum_reporte = new System.Windows.Forms.Label();
            this.lblfecha = new System.Windows.Forms.Label();
            this.lblsintomas = new System.Windows.Forms.Label();
            this.lbltratamiento = new System.Windows.Forms.Label();
            this.lblevolucion = new System.Windows.Forms.Label();
            this.lblid_paciente = new System.Windows.Forms.Label();
            this.lblid_empleado = new System.Windows.Forms.Label();
            this.txtnum_reporte = new System.Windows.Forms.TextBox();
            this.txtsintomas = new System.Windows.Forms.TextBox();
            this.txttratamiento = new System.Windows.Forms.TextBox();
            this.txtevolucion = new System.Windows.Forms.TextBox();
            this.datetFecha = new System.Windows.Forms.DateTimePicker();
            this.cmdregresar = new System.Windows.Forms.Button();
            this.comboid_empleado = new System.Windows.Forms.ComboBox();
            this.comboid_paciente = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Consulta = new System.Windows.Forms.PictureBox();
            this.baja = new System.Windows.Forms.PictureBox();
            this.Subida = new System.Windows.Forms.PictureBox();
            this.modificacion = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Consulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Subida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modificacion)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltitReporte
            // 
            this.lbltitReporte.AutoSize = true;
            this.lbltitReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitReporte.Location = new System.Drawing.Point(49, 37);
            this.lbltitReporte.Name = "lbltitReporte";
            this.lbltitReporte.Size = new System.Drawing.Size(424, 44);
            this.lbltitReporte.TabIndex = 0;
            this.lbltitReporte.Text = "Reporte de seguimiento";
            // 
            // lblNum_reporte
            // 
            this.lblNum_reporte.AutoSize = true;
            this.lblNum_reporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum_reporte.Location = new System.Drawing.Point(34, 96);
            this.lblNum_reporte.Name = "lblNum_reporte";
            this.lblNum_reporte.Size = new System.Drawing.Size(194, 26);
            this.lblNum_reporte.TabIndex = 1;
            this.lblNum_reporte.Text = "Numero de reporte";
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha.Location = new System.Drawing.Point(32, 216);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(72, 26);
            this.lblfecha.TabIndex = 2;
            this.lblfecha.Text = "Fecha";
            // 
            // lblsintomas
            // 
            this.lblsintomas.AutoSize = true;
            this.lblsintomas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsintomas.Location = new System.Drawing.Point(32, 270);
            this.lblsintomas.Name = "lblsintomas";
            this.lblsintomas.Size = new System.Drawing.Size(104, 26);
            this.lblsintomas.TabIndex = 3;
            this.lblsintomas.Text = "Sintomas";
            // 
            // lbltratamiento
            // 
            this.lbltratamiento.AutoSize = true;
            this.lbltratamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltratamiento.Location = new System.Drawing.Point(46, 389);
            this.lbltratamiento.Name = "lbltratamiento";
            this.lbltratamiento.Size = new System.Drawing.Size(127, 26);
            this.lbltratamiento.TabIndex = 4;
            this.lbltratamiento.Text = "Tratamiento";
            // 
            // lblevolucion
            // 
            this.lblevolucion.AutoSize = true;
            this.lblevolucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblevolucion.Location = new System.Drawing.Point(46, 495);
            this.lblevolucion.Name = "lblevolucion";
            this.lblevolucion.Size = new System.Drawing.Size(107, 26);
            this.lblevolucion.TabIndex = 5;
            this.lblevolucion.Text = "Evolucion";
            // 
            // lblid_paciente
            // 
            this.lblid_paciente.AutoSize = true;
            this.lblid_paciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid_paciente.Location = new System.Drawing.Point(34, 137);
            this.lblid_paciente.Name = "lblid_paciente";
            this.lblid_paciente.Size = new System.Drawing.Size(118, 26);
            this.lblid_paciente.TabIndex = 6;
            this.lblid_paciente.Text = "Id paciente";
            // 
            // lblid_empleado
            // 
            this.lblid_empleado.AutoSize = true;
            this.lblid_empleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid_empleado.Location = new System.Drawing.Point(32, 176);
            this.lblid_empleado.Name = "lblid_empleado";
            this.lblid_empleado.Size = new System.Drawing.Size(132, 26);
            this.lblid_empleado.TabIndex = 7;
            this.lblid_empleado.Text = "Id empleado";
            // 
            // txtnum_reporte
            // 
            this.txtnum_reporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnum_reporte.Location = new System.Drawing.Point(266, 93);
            this.txtnum_reporte.Name = "txtnum_reporte";
            this.txtnum_reporte.Size = new System.Drawing.Size(135, 32);
            this.txtnum_reporte.TabIndex = 8;
            // 
            // txtsintomas
            // 
            this.txtsintomas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsintomas.Location = new System.Drawing.Point(266, 266);
            this.txtsintomas.Multiline = true;
            this.txtsintomas.Name = "txtsintomas";
            this.txtsintomas.Size = new System.Drawing.Size(290, 112);
            this.txtsintomas.TabIndex = 10;
            // 
            // txttratamiento
            // 
            this.txttratamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttratamiento.Location = new System.Drawing.Point(266, 387);
            this.txttratamiento.Multiline = true;
            this.txttratamiento.Name = "txttratamiento";
            this.txttratamiento.Size = new System.Drawing.Size(290, 91);
            this.txttratamiento.TabIndex = 11;
            // 
            // txtevolucion
            // 
            this.txtevolucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtevolucion.Location = new System.Drawing.Point(266, 492);
            this.txtevolucion.Multiline = true;
            this.txtevolucion.Name = "txtevolucion";
            this.txtevolucion.Size = new System.Drawing.Size(290, 91);
            this.txtevolucion.TabIndex = 12;
            // 
            // datetFecha
            // 
            this.datetFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetFecha.Location = new System.Drawing.Point(266, 211);
            this.datetFecha.Name = "datetFecha";
            this.datetFecha.Size = new System.Drawing.Size(290, 32);
            this.datetFecha.TabIndex = 16;
            // 
            // cmdregresar
            // 
            this.cmdregresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdregresar.Location = new System.Drawing.Point(8, 11);
            this.cmdregresar.Name = "cmdregresar";
            this.cmdregresar.Size = new System.Drawing.Size(75, 32);
            this.cmdregresar.TabIndex = 19;
            this.cmdregresar.Text = "Menu";
            this.cmdregresar.UseVisualStyleBackColor = true;
            this.cmdregresar.Click += new System.EventHandler(this.cmdregresar_Click);
            // 
            // comboid_empleado
            // 
            this.comboid_empleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboid_empleado.FormattingEnabled = true;
            this.comboid_empleado.Location = new System.Drawing.Point(266, 173);
            this.comboid_empleado.Name = "comboid_empleado";
            this.comboid_empleado.Size = new System.Drawing.Size(135, 34);
            this.comboid_empleado.TabIndex = 20;
            this.comboid_empleado.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboid_paciente
            // 
            this.comboid_paciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboid_paciente.FormattingEnabled = true;
            this.comboid_paciente.Location = new System.Drawing.Point(266, 135);
            this.comboid_paciente.Name = "comboid_paciente";
            this.comboid_paciente.Size = new System.Drawing.Size(135, 34);
            this.comboid_paciente.TabIndex = 21;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(562, 10);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(740, 653);
            this.dataGridView1.TabIndex = 22;
            // 
            // Consulta
            // 
            this.Consulta.Image = ((System.Drawing.Image)(resources.GetObject("Consulta.Image")));
            this.Consulta.Location = new System.Drawing.Point(266, 604);
            this.Consulta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Consulta.Name = "Consulta";
            this.Consulta.Size = new System.Drawing.Size(89, 81);
            this.Consulta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Consulta.TabIndex = 25;
            this.Consulta.TabStop = false;
            this.Consulta.Click += new System.EventHandler(this.Consulta_Click);
            // 
            // baja
            // 
            this.baja.Image = ((System.Drawing.Image)(resources.GetObject("baja.Image")));
            this.baja.Location = new System.Drawing.Point(163, 604);
            this.baja.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.baja.Name = "baja";
            this.baja.Size = new System.Drawing.Size(89, 81);
            this.baja.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.baja.TabIndex = 24;
            this.baja.TabStop = false;
            this.baja.Click += new System.EventHandler(this.baja_Click);
            // 
            // Subida
            // 
            this.Subida.Image = ((System.Drawing.Image)(resources.GetObject("Subida.Image")));
            this.Subida.Location = new System.Drawing.Point(37, 604);
            this.Subida.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Subida.Name = "Subida";
            this.Subida.Size = new System.Drawing.Size(89, 81);
            this.Subida.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Subida.TabIndex = 23;
            this.Subida.TabStop = false;
            this.Subida.Click += new System.EventHandler(this.Subida_Click);
            // 
            // modificacion
            // 
            this.modificacion.Image = ((System.Drawing.Image)(resources.GetObject("modificacion.Image")));
            this.modificacion.Location = new System.Drawing.Point(384, 603);
            this.modificacion.Margin = new System.Windows.Forms.Padding(2);
            this.modificacion.Name = "modificacion";
            this.modificacion.Size = new System.Drawing.Size(89, 81);
            this.modificacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.modificacion.TabIndex = 26;
            this.modificacion.TabStop = false;
            this.modificacion.Click += new System.EventHandler(this.modificacion_Click);
            // 
            // frmReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 695);
            this.Controls.Add(this.modificacion);
            this.Controls.Add(this.Consulta);
            this.Controls.Add(this.baja);
            this.Controls.Add(this.Subida);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboid_paciente);
            this.Controls.Add(this.comboid_empleado);
            this.Controls.Add(this.cmdregresar);
            this.Controls.Add(this.datetFecha);
            this.Controls.Add(this.txtevolucion);
            this.Controls.Add(this.txttratamiento);
            this.Controls.Add(this.txtsintomas);
            this.Controls.Add(this.txtnum_reporte);
            this.Controls.Add(this.lblid_empleado);
            this.Controls.Add(this.lblid_paciente);
            this.Controls.Add(this.lblevolucion);
            this.Controls.Add(this.lbltratamiento);
            this.Controls.Add(this.lblsintomas);
            this.Controls.Add(this.lblfecha);
            this.Controls.Add(this.lblNum_reporte);
            this.Controls.Add(this.lbltitReporte);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReporte";
            this.Text = "Reporte de seguimiento";
            this.Load += new System.EventHandler(this.frmReporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Consulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Subida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modificacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitReporte;
        private System.Windows.Forms.Label lblNum_reporte;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Label lblsintomas;
        private System.Windows.Forms.Label lbltratamiento;
        private System.Windows.Forms.Label lblevolucion;
        private System.Windows.Forms.Label lblid_paciente;
        private System.Windows.Forms.Label lblid_empleado;
        private System.Windows.Forms.TextBox txtnum_reporte;
        private System.Windows.Forms.TextBox txtsintomas;
        private System.Windows.Forms.TextBox txttratamiento;
        private System.Windows.Forms.TextBox txtevolucion;
        private System.Windows.Forms.DateTimePicker datetFecha;
        private System.Windows.Forms.Button cmdregresar;
        private System.Windows.Forms.ComboBox comboid_empleado;
        private System.Windows.Forms.ComboBox comboid_paciente;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox Consulta;
        private System.Windows.Forms.PictureBox baja;
        private System.Windows.Forms.PictureBox Subida;
        private System.Windows.Forms.PictureBox modificacion;
    }
}