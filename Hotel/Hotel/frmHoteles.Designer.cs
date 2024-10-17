
namespace Hotel
{
    partial class frmHoteles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHoteles));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmdmodificacion = new System.Windows.Forms.Button();
            this.cmdconsulta = new System.Windows.Forms.Button();
            this.cmdbaja = new System.Windows.Forms.Button();
            this.cmdcargar = new System.Windows.Forms.Button();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtid_hotel = new System.Windows.Forms.TextBox();
            this.lbltelefono = new System.Windows.Forms.Label();
            this.lbldireccion = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblid_hotel = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(874, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(454, 689);
            this.dataGridView1.TabIndex = 35;
            // 
            // cmdmodificacion
            // 
            this.cmdmodificacion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdmodificacion.BackgroundImage")));
            this.cmdmodificacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdmodificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdmodificacion.Location = new System.Drawing.Point(473, 551);
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
            this.cmdconsulta.Location = new System.Drawing.Point(319, 551);
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
            this.cmdbaja.Location = new System.Drawing.Point(165, 551);
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
            this.cmdcargar.Location = new System.Drawing.Point(11, 551);
            this.cmdcargar.Margin = new System.Windows.Forms.Padding(2);
            this.cmdcargar.Name = "cmdcargar";
            this.cmdcargar.Size = new System.Drawing.Size(150, 150);
            this.cmdcargar.TabIndex = 31;
            this.cmdcargar.UseVisualStyleBackColor = true;
            this.cmdcargar.Click += new System.EventHandler(this.cmdcargar_Click);
            // 
            // txttelefono
            // 
            this.txttelefono.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttelefono.Location = new System.Drawing.Point(173, 204);
            this.txttelefono.Margin = new System.Windows.Forms.Padding(2);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(255, 46);
            this.txttelefono.TabIndex = 26;
            // 
            // txtdireccion
            // 
            this.txtdireccion.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdireccion.Location = new System.Drawing.Point(174, 154);
            this.txtdireccion.Margin = new System.Windows.Forms.Padding(2);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(423, 46);
            this.txtdireccion.TabIndex = 25;
            // 
            // txtnombre
            // 
            this.txtnombre.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.Location = new System.Drawing.Point(174, 104);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(423, 46);
            this.txtnombre.TabIndex = 24;
            // 
            // txtid_hotel
            // 
            this.txtid_hotel.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid_hotel.Location = new System.Drawing.Point(173, 54);
            this.txtid_hotel.Margin = new System.Windows.Forms.Padding(2);
            this.txtid_hotel.Name = "txtid_hotel";
            this.txtid_hotel.Size = new System.Drawing.Size(106, 46);
            this.txtid_hotel.TabIndex = 23;
            // 
            // lbltelefono
            // 
            this.lbltelefono.AutoSize = true;
            this.lbltelefono.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltelefono.ForeColor = System.Drawing.Color.Maroon;
            this.lbltelefono.Location = new System.Drawing.Point(11, 207);
            this.lbltelefono.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltelefono.Name = "lbltelefono";
            this.lbltelefono.Size = new System.Drawing.Size(143, 32);
            this.lbltelefono.TabIndex = 22;
            this.lbltelefono.Text = "Telefono";
            // 
            // lbldireccion
            // 
            this.lbldireccion.AutoSize = true;
            this.lbldireccion.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldireccion.ForeColor = System.Drawing.Color.Maroon;
            this.lbldireccion.Location = new System.Drawing.Point(11, 157);
            this.lbldireccion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbldireccion.Name = "lbldireccion";
            this.lbldireccion.Size = new System.Drawing.Size(159, 32);
            this.lbldireccion.TabIndex = 21;
            this.lbldireccion.Text = "Direccion";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.ForeColor = System.Drawing.Color.Maroon;
            this.lblnombre.Location = new System.Drawing.Point(11, 107);
            this.lblnombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(111, 32);
            this.lblnombre.TabIndex = 20;
            this.lblnombre.Text = "Nombre";
            // 
            // lblid_hotel
            // 
            this.lblid_hotel.AutoSize = true;
            this.lblid_hotel.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid_hotel.ForeColor = System.Drawing.Color.Maroon;
            this.lblid_hotel.Location = new System.Drawing.Point(11, 57);
            this.lblid_hotel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblid_hotel.Name = "lblid_hotel";
            this.lblid_hotel.Size = new System.Drawing.Size(47, 32);
            this.lblid_hotel.TabIndex = 19;
            this.lblid_hotel.Text = "Id";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Maroon;
            this.lblTitulo.Location = new System.Drawing.Point(11, 9);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(195, 48);
            this.lblTitulo.TabIndex = 18;
            this.lblTitulo.Text = "Hoteles";
            // 
            // frmHoteles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1556, 881);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmdmodificacion);
            this.Controls.Add(this.cmdconsulta);
            this.Controls.Add(this.cmdbaja);
            this.Controls.Add(this.cmdcargar);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtid_hotel);
            this.Controls.Add(this.lbltelefono);
            this.Controls.Add(this.lbldireccion);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.lblid_hotel);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHoteles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Hoteles";
            this.Load += new System.EventHandler(this.frmHoteles_Load);
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
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtid_hotel;
        private System.Windows.Forms.Label lbltelefono;
        private System.Windows.Forms.Label lbldireccion;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblid_hotel;
        private System.Windows.Forms.Label lblTitulo;
    }
}