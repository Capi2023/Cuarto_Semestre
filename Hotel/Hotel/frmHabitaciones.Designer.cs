
namespace Hotel
{
    partial class frmHabitaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHabitaciones));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmdmodificacion = new System.Windows.Forms.Button();
            this.cmdconsulta = new System.Windows.Forms.Button();
            this.cmdbaja = new System.Windows.Forms.Button();
            this.cmdcargar = new System.Windows.Forms.Button();
            this.txtnum_personas = new System.Windows.Forms.TextBox();
            this.lblnum_personas = new System.Windows.Forms.Label();
            this.txtnum_baño = new System.Windows.Forms.TextBox();
            this.lblnum_baño = new System.Windows.Forms.Label();
            this.txttipo_cama = new System.Windows.Forms.TextBox();
            this.txtnum_cama = new System.Windows.Forms.TextBox();
            this.txtid_habitacion = new System.Windows.Forms.TextBox();
            this.lbltipo_cama = new System.Windows.Forms.Label();
            this.lblnum_cama = new System.Windows.Forms.Label();
            this.lblid_categoria = new System.Windows.Forms.Label();
            this.lblid_habitacion = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.lbldescripcion = new System.Windows.Forms.Label();
            this.txtterraza = new System.Windows.Forms.TextBox();
            this.txtcosto = new System.Windows.Forms.TextBox();
            this.lblterraza = new System.Windows.Forms.Label();
            this.lblcosto = new System.Windows.Forms.Label();
            this.txtid_categoria = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(752, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(560, 680);
            this.dataGridView1.TabIndex = 35;
            // 
            // cmdmodificacion
            // 
            this.cmdmodificacion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdmodificacion.BackgroundImage")));
            this.cmdmodificacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdmodificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdmodificacion.Location = new System.Drawing.Point(169, 496);
            this.cmdmodificacion.Margin = new System.Windows.Forms.Padding(2);
            this.cmdmodificacion.Name = "cmdmodificacion";
            this.cmdmodificacion.Size = new System.Drawing.Size(150, 150);
            this.cmdmodificacion.TabIndex = 34;
            this.cmdmodificacion.UseVisualStyleBackColor = true;
            this.cmdmodificacion.Click += new System.EventHandler(this.cmdmodificacion_Click);
            // 
            // cmdconsulta
            // 
            this.cmdconsulta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdconsulta.BackgroundImage")));
            this.cmdconsulta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdconsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdconsulta.Location = new System.Drawing.Point(11, 496);
            this.cmdconsulta.Margin = new System.Windows.Forms.Padding(2);
            this.cmdconsulta.Name = "cmdconsulta";
            this.cmdconsulta.Size = new System.Drawing.Size(150, 150);
            this.cmdconsulta.TabIndex = 33;
            this.cmdconsulta.UseVisualStyleBackColor = true;
            this.cmdconsulta.Click += new System.EventHandler(this.cmdconsulta_Click);
            // 
            // cmdbaja
            // 
            this.cmdbaja.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdbaja.BackgroundImage")));
            this.cmdbaja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdbaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdbaja.Location = new System.Drawing.Point(550, 260);
            this.cmdbaja.Margin = new System.Windows.Forms.Padding(2);
            this.cmdbaja.Name = "cmdbaja";
            this.cmdbaja.Size = new System.Drawing.Size(150, 150);
            this.cmdbaja.TabIndex = 32;
            this.cmdbaja.UseVisualStyleBackColor = true;
            this.cmdbaja.Click += new System.EventHandler(this.cmdbaja_Click);
            // 
            // cmdcargar
            // 
            this.cmdcargar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdcargar.BackgroundImage")));
            this.cmdcargar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdcargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdcargar.Location = new System.Drawing.Point(534, 30);
            this.cmdcargar.Margin = new System.Windows.Forms.Padding(2);
            this.cmdcargar.Name = "cmdcargar";
            this.cmdcargar.Size = new System.Drawing.Size(150, 150);
            this.cmdcargar.TabIndex = 31;
            this.cmdcargar.UseVisualStyleBackColor = true;
            this.cmdcargar.Click += new System.EventHandler(this.cmdcargar_Click);
            // 
            // txtnum_personas
            // 
            this.txtnum_personas.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnum_personas.Location = new System.Drawing.Point(323, 302);
            this.txtnum_personas.Margin = new System.Windows.Forms.Padding(2);
            this.txtnum_personas.Name = "txtnum_personas";
            this.txtnum_personas.Size = new System.Drawing.Size(79, 44);
            this.txtnum_personas.TabIndex = 30;
            // 
            // lblnum_personas
            // 
            this.lblnum_personas.AutoSize = true;
            this.lblnum_personas.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnum_personas.ForeColor = System.Drawing.Color.Maroon;
            this.lblnum_personas.Location = new System.Drawing.Point(11, 308);
            this.lblnum_personas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblnum_personas.Name = "lblnum_personas";
            this.lblnum_personas.Size = new System.Drawing.Size(303, 32);
            this.lblnum_personas.TabIndex = 29;
            this.lblnum_personas.Text = "Numero de personas";
            // 
            // txtnum_baño
            // 
            this.txtnum_baño.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnum_baño.Location = new System.Drawing.Point(323, 254);
            this.txtnum_baño.Margin = new System.Windows.Forms.Padding(2);
            this.txtnum_baño.Name = "txtnum_baño";
            this.txtnum_baño.Size = new System.Drawing.Size(79, 44);
            this.txtnum_baño.TabIndex = 28;
            // 
            // lblnum_baño
            // 
            this.lblnum_baño.AutoSize = true;
            this.lblnum_baño.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnum_baño.ForeColor = System.Drawing.Color.Maroon;
            this.lblnum_baño.Location = new System.Drawing.Point(11, 260);
            this.lblnum_baño.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblnum_baño.Name = "lblnum_baño";
            this.lblnum_baño.Size = new System.Drawing.Size(239, 32);
            this.lblnum_baño.TabIndex = 27;
            this.lblnum_baño.Text = "Numero de baño";
            // 
            // txttipo_cama
            // 
            this.txttipo_cama.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttipo_cama.Location = new System.Drawing.Point(323, 206);
            this.txttipo_cama.Margin = new System.Windows.Forms.Padding(2);
            this.txttipo_cama.Name = "txttipo_cama";
            this.txttipo_cama.Size = new System.Drawing.Size(314, 44);
            this.txttipo_cama.TabIndex = 26;
            // 
            // txtnum_cama
            // 
            this.txtnum_cama.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnum_cama.Location = new System.Drawing.Point(323, 158);
            this.txtnum_cama.Margin = new System.Windows.Forms.Padding(2);
            this.txtnum_cama.Name = "txtnum_cama";
            this.txtnum_cama.Size = new System.Drawing.Size(79, 44);
            this.txtnum_cama.TabIndex = 25;
            // 
            // txtid_habitacion
            // 
            this.txtid_habitacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid_habitacion.Location = new System.Drawing.Point(323, 59);
            this.txtid_habitacion.Margin = new System.Windows.Forms.Padding(2);
            this.txtid_habitacion.Name = "txtid_habitacion";
            this.txtid_habitacion.Size = new System.Drawing.Size(121, 44);
            this.txtid_habitacion.TabIndex = 23;
            // 
            // lbltipo_cama
            // 
            this.lbltipo_cama.AutoSize = true;
            this.lbltipo_cama.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltipo_cama.ForeColor = System.Drawing.Color.Maroon;
            this.lbltipo_cama.Location = new System.Drawing.Point(11, 212);
            this.lbltipo_cama.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltipo_cama.Name = "lbltipo_cama";
            this.lbltipo_cama.Size = new System.Drawing.Size(207, 32);
            this.lbltipo_cama.TabIndex = 22;
            this.lbltipo_cama.Text = "Tipo de cama";
            // 
            // lblnum_cama
            // 
            this.lblnum_cama.AutoSize = true;
            this.lblnum_cama.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnum_cama.ForeColor = System.Drawing.Color.Maroon;
            this.lblnum_cama.Location = new System.Drawing.Point(11, 164);
            this.lblnum_cama.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblnum_cama.Name = "lblnum_cama";
            this.lblnum_cama.Size = new System.Drawing.Size(255, 32);
            this.lblnum_cama.TabIndex = 21;
            this.lblnum_cama.Text = "Numero de camas";
            // 
            // lblid_categoria
            // 
            this.lblid_categoria.AutoSize = true;
            this.lblid_categoria.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid_categoria.ForeColor = System.Drawing.Color.Maroon;
            this.lblid_categoria.Location = new System.Drawing.Point(11, 114);
            this.lblid_categoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblid_categoria.Name = "lblid_categoria";
            this.lblid_categoria.Size = new System.Drawing.Size(207, 32);
            this.lblid_categoria.TabIndex = 20;
            this.lblid_categoria.Text = "Id Categoria";
            // 
            // lblid_habitacion
            // 
            this.lblid_habitacion.AutoSize = true;
            this.lblid_habitacion.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid_habitacion.ForeColor = System.Drawing.Color.Maroon;
            this.lblid_habitacion.Location = new System.Drawing.Point(11, 65);
            this.lblid_habitacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblid_habitacion.Name = "lblid_habitacion";
            this.lblid_habitacion.Size = new System.Drawing.Size(223, 32);
            this.lblid_habitacion.TabIndex = 19;
            this.lblid_habitacion.Text = "Id Habitacion";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Maroon;
            this.lblTitulo.Location = new System.Drawing.Point(11, 9);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(320, 48);
            this.lblTitulo.TabIndex = 18;
            this.lblTitulo.Text = "Habitaciones";
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdescripcion.Location = new System.Drawing.Point(323, 446);
            this.txtdescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.txtdescripcion.Multiline = true;
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(419, 270);
            this.txtdescripcion.TabIndex = 41;
            // 
            // lbldescripcion
            // 
            this.lbldescripcion.AutoSize = true;
            this.lbldescripcion.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldescripcion.ForeColor = System.Drawing.Color.Maroon;
            this.lbldescripcion.Location = new System.Drawing.Point(11, 452);
            this.lbldescripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbldescripcion.Name = "lbldescripcion";
            this.lbldescripcion.Size = new System.Drawing.Size(191, 32);
            this.lbldescripcion.TabIndex = 40;
            this.lbldescripcion.Text = "Descripcion";
            // 
            // txtterraza
            // 
            this.txtterraza.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtterraza.Location = new System.Drawing.Point(323, 398);
            this.txtterraza.Margin = new System.Windows.Forms.Padding(2);
            this.txtterraza.Name = "txtterraza";
            this.txtterraza.Size = new System.Drawing.Size(79, 44);
            this.txtterraza.TabIndex = 39;
            // 
            // txtcosto
            // 
            this.txtcosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcosto.Location = new System.Drawing.Point(323, 350);
            this.txtcosto.Margin = new System.Windows.Forms.Padding(2);
            this.txtcosto.Name = "txtcosto";
            this.txtcosto.Size = new System.Drawing.Size(172, 44);
            this.txtcosto.TabIndex = 38;
            // 
            // lblterraza
            // 
            this.lblterraza.AutoSize = true;
            this.lblterraza.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblterraza.ForeColor = System.Drawing.Color.Maroon;
            this.lblterraza.Location = new System.Drawing.Point(13, 404);
            this.lblterraza.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblterraza.Name = "lblterraza";
            this.lblterraza.Size = new System.Drawing.Size(127, 32);
            this.lblterraza.TabIndex = 37;
            this.lblterraza.Text = "Terraza";
            // 
            // lblcosto
            // 
            this.lblcosto.AutoSize = true;
            this.lblcosto.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcosto.ForeColor = System.Drawing.Color.Maroon;
            this.lblcosto.Location = new System.Drawing.Point(13, 356);
            this.lblcosto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblcosto.Name = "lblcosto";
            this.lblcosto.Size = new System.Drawing.Size(95, 32);
            this.lblcosto.TabIndex = 36;
            this.lblcosto.Text = "Costo";
            // 
            // txtid_categoria
            // 
            this.txtid_categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid_categoria.FormattingEnabled = true;
            this.txtid_categoria.Location = new System.Drawing.Point(323, 108);
            this.txtid_categoria.Name = "txtid_categoria";
            this.txtid_categoria.Size = new System.Drawing.Size(121, 45);
            this.txtid_categoria.TabIndex = 42;
            // 
            // frmHabitaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1556, 881);
            this.Controls.Add(this.txtid_categoria);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.lbldescripcion);
            this.Controls.Add(this.txtterraza);
            this.Controls.Add(this.txtcosto);
            this.Controls.Add(this.lblterraza);
            this.Controls.Add(this.lblcosto);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmdmodificacion);
            this.Controls.Add(this.cmdconsulta);
            this.Controls.Add(this.cmdbaja);
            this.Controls.Add(this.cmdcargar);
            this.Controls.Add(this.txtnum_personas);
            this.Controls.Add(this.lblnum_personas);
            this.Controls.Add(this.txtnum_baño);
            this.Controls.Add(this.lblnum_baño);
            this.Controls.Add(this.txttipo_cama);
            this.Controls.Add(this.txtnum_cama);
            this.Controls.Add(this.txtid_habitacion);
            this.Controls.Add(this.lbltipo_cama);
            this.Controls.Add(this.lblnum_cama);
            this.Controls.Add(this.lblid_categoria);
            this.Controls.Add(this.lblid_habitacion);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHabitaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Habitaciones";
            this.Load += new System.EventHandler(this.frmHabitaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button cmdmodificacion;
        private System.Windows.Forms.Button cmdconsulta;
        private System.Windows.Forms.Button cmdbaja;
        private System.Windows.Forms.Button cmdcargar;
        private System.Windows.Forms.TextBox txtnum_personas;
        private System.Windows.Forms.Label lblnum_personas;
        private System.Windows.Forms.TextBox txtnum_baño;
        private System.Windows.Forms.Label lblnum_baño;
        private System.Windows.Forms.TextBox txttipo_cama;
        private System.Windows.Forms.TextBox txtnum_cama;
        private System.Windows.Forms.TextBox txtid_habitacion;
        private System.Windows.Forms.Label lbltipo_cama;
        private System.Windows.Forms.Label lblnum_cama;
        private System.Windows.Forms.Label lblid_categoria;
        private System.Windows.Forms.Label lblid_habitacion;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.Label lbldescripcion;
        private System.Windows.Forms.TextBox txtterraza;
        private System.Windows.Forms.TextBox txtcosto;
        private System.Windows.Forms.Label lblterraza;
        private System.Windows.Forms.Label lblcosto;
        private System.Windows.Forms.ComboBox txtid_categoria;
    }
}