
namespace Hotel
{
    partial class frmReservaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReservaciones));
            this.txtid_habitacion = new System.Windows.Forms.ComboBox();
            this.txtnum_niños = new System.Windows.Forms.TextBox();
            this.lblnum_niños = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmdmodificacion = new System.Windows.Forms.Button();
            this.cmdconsulta = new System.Windows.Forms.Button();
            this.cmdbaja = new System.Windows.Forms.Button();
            this.cmdcargar = new System.Windows.Forms.Button();
            this.txtnum_adultos = new System.Windows.Forms.TextBox();
            this.lblnum_adultos = new System.Windows.Forms.Label();
            this.lblfecha_salida = new System.Windows.Forms.Label();
            this.txtid_reservacion = new System.Windows.Forms.TextBox();
            this.lblfecha_entrada = new System.Windows.Forms.Label();
            this.lblid_cliente = new System.Windows.Forms.Label();
            this.lblid_habitacion = new System.Windows.Forms.Label();
            this.lblid_reservacion = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtid_cliente = new System.Windows.Forms.ComboBox();
            this.txtfecha_entrada = new System.Windows.Forms.DateTimePicker();
            this.txtfecha_salida = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtid_habitacion
            // 
            this.txtid_habitacion.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid_habitacion.FormattingEnabled = true;
            this.txtid_habitacion.Location = new System.Drawing.Point(298, 110);
            this.txtid_habitacion.Name = "txtid_habitacion";
            this.txtid_habitacion.Size = new System.Drawing.Size(121, 40);
            this.txtid_habitacion.TabIndex = 66;
            // 
            // txtnum_niños
            // 
            this.txtnum_niños.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnum_niños.Location = new System.Drawing.Point(298, 351);
            this.txtnum_niños.Margin = new System.Windows.Forms.Padding(2);
            this.txtnum_niños.Name = "txtnum_niños";
            this.txtnum_niños.Size = new System.Drawing.Size(79, 46);
            this.txtnum_niños.TabIndex = 62;
            // 
            // lblnum_niños
            // 
            this.lblnum_niños.AutoSize = true;
            this.lblnum_niños.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnum_niños.ForeColor = System.Drawing.Color.Maroon;
            this.lblnum_niños.Location = new System.Drawing.Point(11, 354);
            this.lblnum_niños.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblnum_niños.Name = "lblnum_niños";
            this.lblnum_niños.Size = new System.Drawing.Size(255, 32);
            this.lblnum_niños.TabIndex = 60;
            this.lblnum_niños.Text = "Numero de niños";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(910, 9);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(459, 676);
            this.dataGridView1.TabIndex = 59;
            // 
            // cmdmodificacion
            // 
            this.cmdmodificacion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdmodificacion.BackgroundImage")));
            this.cmdmodificacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdmodificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdmodificacion.Location = new System.Drawing.Point(473, 536);
            this.cmdmodificacion.Margin = new System.Windows.Forms.Padding(2);
            this.cmdmodificacion.Name = "cmdmodificacion";
            this.cmdmodificacion.Size = new System.Drawing.Size(150, 150);
            this.cmdmodificacion.TabIndex = 58;
            this.cmdmodificacion.UseVisualStyleBackColor = true;
            this.cmdmodificacion.Click += new System.EventHandler(this.cmdmodificacion_Click);
            // 
            // cmdconsulta
            // 
            this.cmdconsulta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdconsulta.BackgroundImage")));
            this.cmdconsulta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdconsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdconsulta.Location = new System.Drawing.Point(319, 536);
            this.cmdconsulta.Margin = new System.Windows.Forms.Padding(2);
            this.cmdconsulta.Name = "cmdconsulta";
            this.cmdconsulta.Size = new System.Drawing.Size(150, 150);
            this.cmdconsulta.TabIndex = 57;
            this.cmdconsulta.UseVisualStyleBackColor = true;
            this.cmdconsulta.Click += new System.EventHandler(this.cmdconsulta_Click);
            // 
            // cmdbaja
            // 
            this.cmdbaja.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdbaja.BackgroundImage")));
            this.cmdbaja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdbaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdbaja.Location = new System.Drawing.Point(165, 535);
            this.cmdbaja.Margin = new System.Windows.Forms.Padding(2);
            this.cmdbaja.Name = "cmdbaja";
            this.cmdbaja.Size = new System.Drawing.Size(150, 150);
            this.cmdbaja.TabIndex = 56;
            this.cmdbaja.UseVisualStyleBackColor = true;
            this.cmdbaja.Click += new System.EventHandler(this.cmdbaja_Click);
            // 
            // cmdcargar
            // 
            this.cmdcargar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdcargar.BackgroundImage")));
            this.cmdcargar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdcargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdcargar.Location = new System.Drawing.Point(11, 536);
            this.cmdcargar.Margin = new System.Windows.Forms.Padding(2);
            this.cmdcargar.Name = "cmdcargar";
            this.cmdcargar.Size = new System.Drawing.Size(150, 150);
            this.cmdcargar.TabIndex = 55;
            this.cmdcargar.UseVisualStyleBackColor = true;
            this.cmdcargar.Click += new System.EventHandler(this.cmdcargar_Click);
            // 
            // txtnum_adultos
            // 
            this.txtnum_adultos.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnum_adultos.Location = new System.Drawing.Point(298, 301);
            this.txtnum_adultos.Margin = new System.Windows.Forms.Padding(2);
            this.txtnum_adultos.Name = "txtnum_adultos";
            this.txtnum_adultos.Size = new System.Drawing.Size(79, 46);
            this.txtnum_adultos.TabIndex = 54;
            // 
            // lblnum_adultos
            // 
            this.lblnum_adultos.AutoSize = true;
            this.lblnum_adultos.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnum_adultos.ForeColor = System.Drawing.Color.Maroon;
            this.lblnum_adultos.Location = new System.Drawing.Point(11, 304);
            this.lblnum_adultos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblnum_adultos.Name = "lblnum_adultos";
            this.lblnum_adultos.Size = new System.Drawing.Size(287, 32);
            this.lblnum_adultos.TabIndex = 53;
            this.lblnum_adultos.Text = "Numero de adultos";
            // 
            // lblfecha_salida
            // 
            this.lblfecha_salida.AutoSize = true;
            this.lblfecha_salida.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha_salida.ForeColor = System.Drawing.Color.Maroon;
            this.lblfecha_salida.Location = new System.Drawing.Point(11, 260);
            this.lblfecha_salida.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblfecha_salida.Name = "lblfecha_salida";
            this.lblfecha_salida.Size = new System.Drawing.Size(255, 32);
            this.lblfecha_salida.TabIndex = 51;
            this.lblfecha_salida.Text = "Fecha de salida";
            // 
            // txtid_reservacion
            // 
            this.txtid_reservacion.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid_reservacion.Location = new System.Drawing.Point(298, 59);
            this.txtid_reservacion.Margin = new System.Windows.Forms.Padding(2);
            this.txtid_reservacion.Name = "txtid_reservacion";
            this.txtid_reservacion.Size = new System.Drawing.Size(121, 46);
            this.txtid_reservacion.TabIndex = 48;
            // 
            // lblfecha_entrada
            // 
            this.lblfecha_entrada.AutoSize = true;
            this.lblfecha_entrada.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha_entrada.ForeColor = System.Drawing.Color.Maroon;
            this.lblfecha_entrada.Location = new System.Drawing.Point(11, 210);
            this.lblfecha_entrada.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblfecha_entrada.Name = "lblfecha_entrada";
            this.lblfecha_entrada.Size = new System.Drawing.Size(271, 32);
            this.lblfecha_entrada.TabIndex = 47;
            this.lblfecha_entrada.Text = "Fecha de entrada";
            // 
            // lblid_cliente
            // 
            this.lblid_cliente.AutoSize = true;
            this.lblid_cliente.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid_cliente.ForeColor = System.Drawing.Color.Maroon;
            this.lblid_cliente.Location = new System.Drawing.Point(11, 159);
            this.lblid_cliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblid_cliente.Name = "lblid_cliente";
            this.lblid_cliente.Size = new System.Drawing.Size(175, 32);
            this.lblid_cliente.TabIndex = 46;
            this.lblid_cliente.Text = "Id Cliente";
            // 
            // lblid_habitacion
            // 
            this.lblid_habitacion.AutoSize = true;
            this.lblid_habitacion.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid_habitacion.ForeColor = System.Drawing.Color.Maroon;
            this.lblid_habitacion.Location = new System.Drawing.Point(13, 113);
            this.lblid_habitacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblid_habitacion.Name = "lblid_habitacion";
            this.lblid_habitacion.Size = new System.Drawing.Size(223, 32);
            this.lblid_habitacion.TabIndex = 45;
            this.lblid_habitacion.Text = "Id Habitacion";
            // 
            // lblid_reservacion
            // 
            this.lblid_reservacion.AutoSize = true;
            this.lblid_reservacion.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid_reservacion.ForeColor = System.Drawing.Color.Maroon;
            this.lblid_reservacion.Location = new System.Drawing.Point(11, 62);
            this.lblid_reservacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblid_reservacion.Name = "lblid_reservacion";
            this.lblid_reservacion.Size = new System.Drawing.Size(239, 32);
            this.lblid_reservacion.TabIndex = 44;
            this.lblid_reservacion.Text = "Id Reservacion";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Maroon;
            this.lblTitulo.Location = new System.Drawing.Point(11, 9);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(345, 48);
            this.lblTitulo.TabIndex = 43;
            this.lblTitulo.Text = "Reservaciones";
            // 
            // txtid_cliente
            // 
            this.txtid_cliente.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid_cliente.FormattingEnabled = true;
            this.txtid_cliente.Location = new System.Drawing.Point(298, 156);
            this.txtid_cliente.Name = "txtid_cliente";
            this.txtid_cliente.Size = new System.Drawing.Size(121, 40);
            this.txtid_cliente.TabIndex = 68;
            // 
            // txtfecha_entrada
            // 
            this.txtfecha_entrada.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfecha_entrada.CalendarForeColor = System.Drawing.Color.Maroon;
            this.txtfecha_entrada.CalendarTitleBackColor = System.Drawing.Color.White;
            this.txtfecha_entrada.CalendarTitleForeColor = System.Drawing.Color.Maroon;
            this.txtfecha_entrada.CalendarTrailingForeColor = System.Drawing.Color.Maroon;
            this.txtfecha_entrada.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfecha_entrada.Location = new System.Drawing.Point(298, 201);
            this.txtfecha_entrada.Margin = new System.Windows.Forms.Padding(2);
            this.txtfecha_entrada.Name = "txtfecha_entrada";
            this.txtfecha_entrada.Size = new System.Drawing.Size(607, 46);
            this.txtfecha_entrada.TabIndex = 69;
            // 
            // txtfecha_salida
            // 
            this.txtfecha_salida.CalendarForeColor = System.Drawing.Color.Maroon;
            this.txtfecha_salida.CalendarTitleBackColor = System.Drawing.Color.White;
            this.txtfecha_salida.CalendarTitleForeColor = System.Drawing.Color.Maroon;
            this.txtfecha_salida.CalendarTrailingForeColor = System.Drawing.Color.Maroon;
            this.txtfecha_salida.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfecha_salida.Location = new System.Drawing.Point(298, 251);
            this.txtfecha_salida.Margin = new System.Windows.Forms.Padding(2);
            this.txtfecha_salida.Name = "txtfecha_salida";
            this.txtfecha_salida.Size = new System.Drawing.Size(607, 46);
            this.txtfecha_salida.TabIndex = 70;
            // 
            // frmReservaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1556, 881);
            this.Controls.Add(this.txtfecha_salida);
            this.Controls.Add(this.txtfecha_entrada);
            this.Controls.Add(this.txtid_cliente);
            this.Controls.Add(this.txtid_habitacion);
            this.Controls.Add(this.txtnum_niños);
            this.Controls.Add(this.lblnum_niños);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmdmodificacion);
            this.Controls.Add(this.cmdconsulta);
            this.Controls.Add(this.cmdbaja);
            this.Controls.Add(this.cmdcargar);
            this.Controls.Add(this.txtnum_adultos);
            this.Controls.Add(this.lblnum_adultos);
            this.Controls.Add(this.lblfecha_salida);
            this.Controls.Add(this.txtid_reservacion);
            this.Controls.Add(this.lblfecha_entrada);
            this.Controls.Add(this.lblid_cliente);
            this.Controls.Add(this.lblid_habitacion);
            this.Controls.Add(this.lblid_reservacion);
            this.Controls.Add(this.lblTitulo);
            this.ForeColor = System.Drawing.Color.Maroon;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReservaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmReservaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox txtid_habitacion;
        private System.Windows.Forms.TextBox txtnum_niños;
        private System.Windows.Forms.Label lblnum_niños;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button cmdmodificacion;
        private System.Windows.Forms.Button cmdconsulta;
        private System.Windows.Forms.Button cmdbaja;
        private System.Windows.Forms.Button cmdcargar;
        private System.Windows.Forms.TextBox txtnum_adultos;
        private System.Windows.Forms.Label lblnum_adultos;
        private System.Windows.Forms.Label lblfecha_salida;
        private System.Windows.Forms.TextBox txtid_reservacion;
        private System.Windows.Forms.Label lblfecha_entrada;
        private System.Windows.Forms.Label lblid_cliente;
        private System.Windows.Forms.Label lblid_habitacion;
        private System.Windows.Forms.Label lblid_reservacion;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ComboBox txtid_cliente;
        private System.Windows.Forms.DateTimePicker txtfecha_entrada;
        private System.Windows.Forms.DateTimePicker txtfecha_salida;
    }
}