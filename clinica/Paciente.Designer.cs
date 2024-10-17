
namespace clinica
{
    partial class frmPaciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPaciente));
            this.lblId = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblNumero_SS = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtSS = new System.Windows.Forms.TextBox();
            this.txtedad = new System.Windows.Forms.TextBox();
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.lbltitulo_Paciente = new System.Windows.Forms.Label();
            this.cmdregresar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clinicaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clinicaDataSet = new clinica.clinicaDataSet();
            this.clinicaDataSet1 = new clinica.clinicaDataSet();
            this.Subida = new System.Windows.Forms.PictureBox();
            this.baja = new System.Windows.Forms.PictureBox();
            this.Consulta = new System.Windows.Forms.PictureBox();
            this.modificacion = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Subida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Consulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modificacion)).BeginInit();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(54, 84);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(38, 32);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Id";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(54, 127);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(115, 32);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblNumero_SS
            // 
            this.lblNumero_SS.AutoSize = true;
            this.lblNumero_SS.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero_SS.Location = new System.Drawing.Point(54, 171);
            this.lblNumero_SS.Name = "lblNumero_SS";
            this.lblNumero_SS.Size = new System.Drawing.Size(300, 32);
            this.lblNumero_SS.TabIndex = 2;
            this.lblNumero_SS.Text = "Numero Seguro Social";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdad.Location = new System.Drawing.Point(54, 217);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(82, 32);
            this.lblEdad.TabIndex = 3;
            this.lblEdad.Text = "Edad";
            // 
            // lblFecha
            // 
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(54, 257);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(124, 33);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "Fecha de ingreso";
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(368, 81);
            this.txtid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(209, 38);
            this.txtid.TabIndex = 4;
            // 
            // txtnombre
            // 
            this.txtnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.Location = new System.Drawing.Point(368, 124);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(209, 38);
            this.txtnombre.TabIndex = 5;
            // 
            // txtSS
            // 
            this.txtSS.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSS.Location = new System.Drawing.Point(368, 168);
            this.txtSS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSS.Name = "txtSS";
            this.txtSS.Size = new System.Drawing.Size(209, 38);
            this.txtSS.TabIndex = 6;
            // 
            // txtedad
            // 
            this.txtedad.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtedad.Location = new System.Drawing.Point(368, 214);
            this.txtedad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtedad.Name = "txtedad";
            this.txtedad.Size = new System.Drawing.Size(209, 38);
            this.txtedad.TabIndex = 7;
            // 
            // txtfecha
            // 
            this.txtfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfecha.Location = new System.Drawing.Point(368, 254);
            this.txtfecha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(209, 38);
            this.txtfecha.TabIndex = 8;
            // 
            // lbltitulo_Paciente
            // 
            this.lbltitulo_Paciente.AutoSize = true;
            this.lbltitulo_Paciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo_Paciente.Location = new System.Drawing.Point(164, 9);
            this.lbltitulo_Paciente.Name = "lbltitulo_Paciente";
            this.lbltitulo_Paciente.Size = new System.Drawing.Size(235, 55);
            this.lbltitulo_Paciente.TabIndex = 9;
            this.lbltitulo_Paciente.Text = "Pacientes";
            // 
            // cmdregresar
            // 
            this.cmdregresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdregresar.Location = new System.Drawing.Point(13, 9);
            this.cmdregresar.Margin = new System.Windows.Forms.Padding(4);
            this.cmdregresar.Name = "cmdregresar";
            this.cmdregresar.Size = new System.Drawing.Size(100, 41);
            this.cmdregresar.TabIndex = 13;
            this.cmdregresar.Text = "Menu";
            this.cmdregresar.UseVisualStyleBackColor = true;
            this.cmdregresar.Click += new System.EventHandler(this.cmdregresar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(595, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(740, 368);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // clinicaDataSetBindingSource
            // 
            this.clinicaDataSetBindingSource.DataSource = this.clinicaDataSet;
            this.clinicaDataSetBindingSource.Position = 0;
            // 
            // clinicaDataSet
            // 
            this.clinicaDataSet.DataSetName = "clinicaDataSet";
            this.clinicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clinicaDataSet1
            // 
            this.clinicaDataSet1.DataSetName = "clinicaDataSet";
            this.clinicaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Subida
            // 
            this.Subida.Image = ((System.Drawing.Image)(resources.GetObject("Subida.Image")));
            this.Subida.Location = new System.Drawing.Point(27, 297);
            this.Subida.Name = "Subida";
            this.Subida.Size = new System.Drawing.Size(119, 100);
            this.Subida.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Subida.TabIndex = 15;
            this.Subida.TabStop = false;
            this.Subida.Click += new System.EventHandler(this.Subida_Click);
            // 
            // baja
            // 
            this.baja.Image = ((System.Drawing.Image)(resources.GetObject("baja.Image")));
            this.baja.Location = new System.Drawing.Point(174, 297);
            this.baja.Name = "baja";
            this.baja.Size = new System.Drawing.Size(119, 100);
            this.baja.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.baja.TabIndex = 16;
            this.baja.TabStop = false;
            this.baja.Click += new System.EventHandler(this.baja_Click);
            // 
            // Consulta
            // 
            this.Consulta.Image = ((System.Drawing.Image)(resources.GetObject("Consulta.Image")));
            this.Consulta.Location = new System.Drawing.Point(316, 297);
            this.Consulta.Name = "Consulta";
            this.Consulta.Size = new System.Drawing.Size(119, 100);
            this.Consulta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Consulta.TabIndex = 17;
            this.Consulta.TabStop = false;
            this.Consulta.Click += new System.EventHandler(this.Consulta_Click);
            // 
            // modificacion
            // 
            this.modificacion.Image = ((System.Drawing.Image)(resources.GetObject("modificacion.Image")));
            this.modificacion.Location = new System.Drawing.Point(458, 297);
            this.modificacion.Name = "modificacion";
            this.modificacion.Size = new System.Drawing.Size(119, 100);
            this.modificacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.modificacion.TabIndex = 18;
            this.modificacion.TabStop = false;
            this.modificacion.Click += new System.EventHandler(this.modificacion_Click);
            // 
            // frmPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 415);
            this.Controls.Add(this.modificacion);
            this.Controls.Add(this.Consulta);
            this.Controls.Add(this.baja);
            this.Controls.Add(this.Subida);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmdregresar);
            this.Controls.Add(this.lbltitulo_Paciente);
            this.Controls.Add(this.txtfecha);
            this.Controls.Add(this.txtedad);
            this.Controls.Add(this.txtSS);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblNumero_SS);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblId);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmPaciente";
            this.Text = "Paciente";
            this.Load += new System.EventHandler(this.frmPaciente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Subida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Consulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modificacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblNumero_SS;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtSS;
        private System.Windows.Forms.TextBox txtedad;
        private System.Windows.Forms.TextBox txtfecha;
        private System.Windows.Forms.Label lbltitulo_Paciente;
        private System.Windows.Forms.Button cmdregresar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource clinicaDataSetBindingSource;
        private clinicaDataSet clinicaDataSet;
        private clinicaDataSet clinicaDataSet1;
        private System.Windows.Forms.PictureBox Subida;
        private System.Windows.Forms.PictureBox baja;
        private System.Windows.Forms.PictureBox Consulta;
        private System.Windows.Forms.PictureBox modificacion;
    }
}