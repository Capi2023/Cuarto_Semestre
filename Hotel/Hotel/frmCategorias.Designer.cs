
namespace Hotel
{
    partial class frmCategorias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCategorias));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmdmodificacion = new System.Windows.Forms.Button();
            this.cmdconsulta = new System.Windows.Forms.Button();
            this.cmdbaja = new System.Windows.Forms.Button();
            this.cmdcargar = new System.Windows.Forms.Button();
            this.txtid_categoria = new System.Windows.Forms.TextBox();
            this.lblid_hotel = new System.Windows.Forms.Label();
            this.lblid_categoria = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtid_hotel = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1064, 9);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(253, 860);
            this.dataGridView1.TabIndex = 49;
            // 
            // cmdmodificacion
            // 
            this.cmdmodificacion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdmodificacion.BackgroundImage")));
            this.cmdmodificacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdmodificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdmodificacion.Location = new System.Drawing.Point(473, 561);
            this.cmdmodificacion.Margin = new System.Windows.Forms.Padding(2);
            this.cmdmodificacion.Name = "cmdmodificacion";
            this.cmdmodificacion.Size = new System.Drawing.Size(150, 150);
            this.cmdmodificacion.TabIndex = 48;
            this.cmdmodificacion.UseVisualStyleBackColor = true;
            this.cmdmodificacion.Click += new System.EventHandler(this.cmdmodificacion_Click);
            // 
            // cmdconsulta
            // 
            this.cmdconsulta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdconsulta.BackgroundImage")));
            this.cmdconsulta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdconsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdconsulta.Location = new System.Drawing.Point(319, 561);
            this.cmdconsulta.Margin = new System.Windows.Forms.Padding(2);
            this.cmdconsulta.Name = "cmdconsulta";
            this.cmdconsulta.Size = new System.Drawing.Size(150, 150);
            this.cmdconsulta.TabIndex = 47;
            this.cmdconsulta.UseVisualStyleBackColor = true;
            this.cmdconsulta.Click += new System.EventHandler(this.cmdconsulta_Click);
            // 
            // cmdbaja
            // 
            this.cmdbaja.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdbaja.BackgroundImage")));
            this.cmdbaja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdbaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdbaja.Location = new System.Drawing.Point(165, 561);
            this.cmdbaja.Margin = new System.Windows.Forms.Padding(2);
            this.cmdbaja.Name = "cmdbaja";
            this.cmdbaja.Size = new System.Drawing.Size(150, 150);
            this.cmdbaja.TabIndex = 46;
            this.cmdbaja.UseVisualStyleBackColor = true;
            this.cmdbaja.Click += new System.EventHandler(this.cmdbaja_Click);
            // 
            // cmdcargar
            // 
            this.cmdcargar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdcargar.BackgroundImage")));
            this.cmdcargar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdcargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdcargar.Location = new System.Drawing.Point(11, 561);
            this.cmdcargar.Margin = new System.Windows.Forms.Padding(2);
            this.cmdcargar.Name = "cmdcargar";
            this.cmdcargar.Size = new System.Drawing.Size(150, 150);
            this.cmdcargar.TabIndex = 45;
            this.cmdcargar.UseVisualStyleBackColor = true;
            this.cmdcargar.Click += new System.EventHandler(this.cmdcargar_Click);
            // 
            // txtid_categoria
            // 
            this.txtid_categoria.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid_categoria.Location = new System.Drawing.Point(241, 59);
            this.txtid_categoria.Margin = new System.Windows.Forms.Padding(2);
            this.txtid_categoria.Name = "txtid_categoria";
            this.txtid_categoria.Size = new System.Drawing.Size(106, 46);
            this.txtid_categoria.TabIndex = 41;
            // 
            // lblid_hotel
            // 
            this.lblid_hotel.AutoSize = true;
            this.lblid_hotel.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid_hotel.ForeColor = System.Drawing.Color.Maroon;
            this.lblid_hotel.Location = new System.Drawing.Point(11, 116);
            this.lblid_hotel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblid_hotel.Name = "lblid_hotel";
            this.lblid_hotel.Size = new System.Drawing.Size(143, 32);
            this.lblid_hotel.TabIndex = 38;
            this.lblid_hotel.Text = "Id Hotel";
            // 
            // lblid_categoria
            // 
            this.lblid_categoria.AutoSize = true;
            this.lblid_categoria.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid_categoria.ForeColor = System.Drawing.Color.Maroon;
            this.lblid_categoria.Location = new System.Drawing.Point(11, 62);
            this.lblid_categoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblid_categoria.Name = "lblid_categoria";
            this.lblid_categoria.Size = new System.Drawing.Size(207, 32);
            this.lblid_categoria.TabIndex = 37;
            this.lblid_categoria.Text = "Id Categoria";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Maroon;
            this.lblTitulo.Location = new System.Drawing.Point(11, 9);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(270, 48);
            this.lblTitulo.TabIndex = 36;
            this.lblTitulo.Text = "Categorias";
            // 
            // txtid_hotel
            // 
            this.txtid_hotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid_hotel.FormattingEnabled = true;
            this.txtid_hotel.Location = new System.Drawing.Point(241, 110);
            this.txtid_hotel.Name = "txtid_hotel";
            this.txtid_hotel.Size = new System.Drawing.Size(106, 45);
            this.txtid_hotel.TabIndex = 50;
            // 
            // frmCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1556, 881);
            this.Controls.Add(this.txtid_hotel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmdmodificacion);
            this.Controls.Add(this.cmdconsulta);
            this.Controls.Add(this.cmdbaja);
            this.Controls.Add(this.cmdcargar);
            this.Controls.Add(this.txtid_categoria);
            this.Controls.Add(this.lblid_hotel);
            this.Controls.Add(this.lblid_categoria);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCategorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmCategorias";
            this.Load += new System.EventHandler(this.frmCategorias_Load);
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
        private System.Windows.Forms.TextBox txtid_categoria;
        private System.Windows.Forms.Label lblid_hotel;
        private System.Windows.Forms.Label lblid_categoria;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ComboBox txtid_hotel;
    }
}