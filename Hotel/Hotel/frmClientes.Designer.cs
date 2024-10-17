
namespace Hotel
{
    partial class frmClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClientes));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblid_cliente = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lbldireccion = new System.Windows.Forms.Label();
            this.lbltelefono = new System.Windows.Forms.Label();
            this.txtid_cliente = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.lblemail = new System.Windows.Forms.Label();
            this.txtnum_tarjeta = new System.Windows.Forms.TextBox();
            this.lblnum_tarjeta = new System.Windows.Forms.Label();
            this.cmdcargar = new System.Windows.Forms.Button();
            this.cmdbaja = new System.Windows.Forms.Button();
            this.cmdconsulta = new System.Windows.Forms.Button();
            this.cmdmodificacion = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Maroon;
            this.lblTitulo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTitulo.Location = new System.Drawing.Point(11, 9);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(220, 48);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Clientes";
            // 
            // lblid_cliente
            // 
            this.lblid_cliente.AutoSize = true;
            this.lblid_cliente.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid_cliente.ForeColor = System.Drawing.Color.Maroon;
            this.lblid_cliente.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblid_cliente.Location = new System.Drawing.Point(11, 79);
            this.lblid_cliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblid_cliente.Name = "lblid_cliente";
            this.lblid_cliente.Size = new System.Drawing.Size(47, 32);
            this.lblid_cliente.TabIndex = 1;
            this.lblid_cliente.Text = "Id";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.ForeColor = System.Drawing.Color.Maroon;
            this.lblnombre.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblnombre.Location = new System.Drawing.Point(11, 129);
            this.lblnombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(111, 32);
            this.lblnombre.TabIndex = 2;
            this.lblnombre.Text = "Nombre";
            // 
            // lbldireccion
            // 
            this.lbldireccion.AutoSize = true;
            this.lbldireccion.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldireccion.ForeColor = System.Drawing.Color.Maroon;
            this.lbldireccion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbldireccion.Location = new System.Drawing.Point(11, 179);
            this.lbldireccion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbldireccion.Name = "lbldireccion";
            this.lbldireccion.Size = new System.Drawing.Size(159, 32);
            this.lbldireccion.TabIndex = 3;
            this.lbldireccion.Text = "Direccion";
            // 
            // lbltelefono
            // 
            this.lbltelefono.AutoSize = true;
            this.lbltelefono.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltelefono.ForeColor = System.Drawing.Color.Maroon;
            this.lbltelefono.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbltelefono.Location = new System.Drawing.Point(11, 229);
            this.lbltelefono.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltelefono.Name = "lbltelefono";
            this.lbltelefono.Size = new System.Drawing.Size(143, 32);
            this.lbltelefono.TabIndex = 4;
            this.lbltelefono.Text = "Telefono";
            // 
            // txtid_cliente
            // 
            this.txtid_cliente.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid_cliente.Location = new System.Drawing.Point(298, 76);
            this.txtid_cliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtid_cliente.Name = "txtid_cliente";
            this.txtid_cliente.Size = new System.Drawing.Size(131, 46);
            this.txtid_cliente.TabIndex = 5;
            // 
            // txtnombre
            // 
            this.txtnombre.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.Location = new System.Drawing.Point(298, 126);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(575, 46);
            this.txtnombre.TabIndex = 6;
            // 
            // txtdireccion
            // 
            this.txtdireccion.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdireccion.Location = new System.Drawing.Point(298, 176);
            this.txtdireccion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(575, 46);
            this.txtdireccion.TabIndex = 7;
            // 
            // txttelefono
            // 
            this.txttelefono.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttelefono.Location = new System.Drawing.Point(298, 226);
            this.txttelefono.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(230, 46);
            this.txttelefono.TabIndex = 8;
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(298, 276);
            this.txtemail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(447, 46);
            this.txtemail.TabIndex = 10;
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.ForeColor = System.Drawing.Color.Maroon;
            this.lblemail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblemail.Location = new System.Drawing.Point(11, 279);
            this.lblemail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(95, 32);
            this.lblemail.TabIndex = 9;
            this.lblemail.Text = "Email";
            // 
            // txtnum_tarjeta
            // 
            this.txtnum_tarjeta.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnum_tarjeta.Location = new System.Drawing.Point(298, 326);
            this.txtnum_tarjeta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtnum_tarjeta.Name = "txtnum_tarjeta";
            this.txtnum_tarjeta.Size = new System.Drawing.Size(314, 46);
            this.txtnum_tarjeta.TabIndex = 12;
            // 
            // lblnum_tarjeta
            // 
            this.lblnum_tarjeta.AutoSize = true;
            this.lblnum_tarjeta.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnum_tarjeta.ForeColor = System.Drawing.Color.Maroon;
            this.lblnum_tarjeta.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblnum_tarjeta.Location = new System.Drawing.Point(11, 329);
            this.lblnum_tarjeta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblnum_tarjeta.Name = "lblnum_tarjeta";
            this.lblnum_tarjeta.Size = new System.Drawing.Size(287, 32);
            this.lblnum_tarjeta.TabIndex = 11;
            this.lblnum_tarjeta.Text = "Numero de tarjeta";
            // 
            // cmdcargar
            // 
            this.cmdcargar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdcargar.BackgroundImage")));
            this.cmdcargar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdcargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.cmdcargar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmdcargar.Location = new System.Drawing.Point(4, 557);
            this.cmdcargar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmdcargar.Name = "cmdcargar";
            this.cmdcargar.Size = new System.Drawing.Size(150, 150);
            this.cmdcargar.TabIndex = 13;
            this.cmdcargar.UseVisualStyleBackColor = true;
            this.cmdcargar.Click += new System.EventHandler(this.cmdcargar_Click);
            // 
            // cmdbaja
            // 
            this.cmdbaja.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdbaja.BackgroundImage")));
            this.cmdbaja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdbaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.cmdbaja.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmdbaja.Location = new System.Drawing.Point(158, 557);
            this.cmdbaja.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmdbaja.Name = "cmdbaja";
            this.cmdbaja.Size = new System.Drawing.Size(150, 150);
            this.cmdbaja.TabIndex = 14;
            this.cmdbaja.UseVisualStyleBackColor = true;
            this.cmdbaja.Click += new System.EventHandler(this.cmdbaja_Click);
            // 
            // cmdconsulta
            // 
            this.cmdconsulta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdconsulta.BackgroundImage")));
            this.cmdconsulta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdconsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.cmdconsulta.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmdconsulta.Location = new System.Drawing.Point(312, 557);
            this.cmdconsulta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmdconsulta.Name = "cmdconsulta";
            this.cmdconsulta.Size = new System.Drawing.Size(150, 150);
            this.cmdconsulta.TabIndex = 15;
            this.cmdconsulta.UseVisualStyleBackColor = true;
            this.cmdconsulta.Click += new System.EventHandler(this.cmdconsulta_Click);
            // 
            // cmdmodificacion
            // 
            this.cmdmodificacion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdmodificacion.BackgroundImage")));
            this.cmdmodificacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdmodificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.cmdmodificacion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmdmodificacion.Location = new System.Drawing.Point(466, 557);
            this.cmdmodificacion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmdmodificacion.Name = "cmdmodificacion";
            this.cmdmodificacion.Size = new System.Drawing.Size(150, 150);
            this.cmdmodificacion.TabIndex = 16;
            this.cmdmodificacion.UseVisualStyleBackColor = true;
            this.cmdmodificacion.Click += new System.EventHandler(this.cmdmodificacion_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(630, 329);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(672, 384);
            this.dataGridView1.TabIndex = 17;
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1365, 718);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmdmodificacion);
            this.Controls.Add(this.cmdconsulta);
            this.Controls.Add(this.cmdbaja);
            this.Controls.Add(this.cmdcargar);
            this.Controls.Add(this.txtnum_tarjeta);
            this.Controls.Add(this.lblnum_tarjeta);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtid_cliente);
            this.Controls.Add(this.lbltelefono);
            this.Controls.Add(this.lbldireccion);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.lblid_cliente);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblid_cliente;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lbldireccion;
        private System.Windows.Forms.Label lbltelefono;
        private System.Windows.Forms.TextBox txtid_cliente;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.TextBox txtnum_tarjeta;
        private System.Windows.Forms.Label lblnum_tarjeta;
        private System.Windows.Forms.Button cmdcargar;
        private System.Windows.Forms.Button cmdbaja;
        private System.Windows.Forms.Button cmdconsulta;
        private System.Windows.Forms.Button cmdmodificacion;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}