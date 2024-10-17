
namespace Hotel
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cmdClientes = new System.Windows.Forms.Button();
            this.cmdReservaciones = new System.Windows.Forms.Button();
            this.cmdHabitaciones = new System.Windows.Forms.Button();
            this.cmdCategorias = new System.Windows.Forms.Button();
            this.cmdHoteles = new System.Windows.Forms.Button();
            this.lbltit1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdClientes
            // 
            this.cmdClientes.BackColor = System.Drawing.Color.Maroon;
            this.cmdClientes.FlatAppearance.BorderSize = 0;
            this.cmdClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdClientes.ForeColor = System.Drawing.Color.White;
            this.cmdClientes.Location = new System.Drawing.Point(0, 198);
            this.cmdClientes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmdClientes.Name = "cmdClientes";
            this.cmdClientes.Size = new System.Drawing.Size(201, 61);
            this.cmdClientes.TabIndex = 0;
            this.cmdClientes.Text = "Cliente";
            this.cmdClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdClientes.UseVisualStyleBackColor = false;
            this.cmdClientes.Click += new System.EventHandler(this.cmdClientes_Click);
            // 
            // cmdReservaciones
            // 
            this.cmdReservaciones.BackColor = System.Drawing.Color.Maroon;
            this.cmdReservaciones.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cmdReservaciones.FlatAppearance.BorderSize = 0;
            this.cmdReservaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdReservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdReservaciones.ForeColor = System.Drawing.Color.White;
            this.cmdReservaciones.Location = new System.Drawing.Point(0, 120);
            this.cmdReservaciones.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmdReservaciones.Name = "cmdReservaciones";
            this.cmdReservaciones.Size = new System.Drawing.Size(201, 61);
            this.cmdReservaciones.TabIndex = 1;
            this.cmdReservaciones.Text = "Reservaciones";
            this.cmdReservaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdReservaciones.UseVisualStyleBackColor = false;
            this.cmdReservaciones.Click += new System.EventHandler(this.cmdReservaciones_Click);
            // 
            // cmdHabitaciones
            // 
            this.cmdHabitaciones.BackColor = System.Drawing.Color.Maroon;
            this.cmdHabitaciones.FlatAppearance.BorderSize = 0;
            this.cmdHabitaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdHabitaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdHabitaciones.ForeColor = System.Drawing.Color.White;
            this.cmdHabitaciones.Location = new System.Drawing.Point(2, 277);
            this.cmdHabitaciones.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmdHabitaciones.Name = "cmdHabitaciones";
            this.cmdHabitaciones.Size = new System.Drawing.Size(199, 61);
            this.cmdHabitaciones.TabIndex = 2;
            this.cmdHabitaciones.Text = "Habitaciones";
            this.cmdHabitaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdHabitaciones.UseVisualStyleBackColor = false;
            this.cmdHabitaciones.Click += new System.EventHandler(this.cmdHabitaciones_Click);
            // 
            // cmdCategorias
            // 
            this.cmdCategorias.BackColor = System.Drawing.Color.Maroon;
            this.cmdCategorias.FlatAppearance.BorderSize = 0;
            this.cmdCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCategorias.ForeColor = System.Drawing.Color.White;
            this.cmdCategorias.Location = new System.Drawing.Point(0, 351);
            this.cmdCategorias.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmdCategorias.Name = "cmdCategorias";
            this.cmdCategorias.Size = new System.Drawing.Size(201, 61);
            this.cmdCategorias.TabIndex = 3;
            this.cmdCategorias.Text = "Categorias";
            this.cmdCategorias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdCategorias.UseVisualStyleBackColor = false;
            this.cmdCategorias.Click += new System.EventHandler(this.cmdCategorias_Click);
            // 
            // cmdHoteles
            // 
            this.cmdHoteles.FlatAppearance.BorderSize = 0;
            this.cmdHoteles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdHoteles.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdHoteles.ForeColor = System.Drawing.Color.White;
            this.cmdHoteles.Location = new System.Drawing.Point(2, 425);
            this.cmdHoteles.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmdHoteles.Name = "cmdHoteles";
            this.cmdHoteles.Size = new System.Drawing.Size(199, 61);
            this.cmdHoteles.TabIndex = 4;
            this.cmdHoteles.Text = "Hoteles";
            this.cmdHoteles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdHoteles.UseVisualStyleBackColor = true;
            this.cmdHoteles.Click += new System.EventHandler(this.cmdHoteles_Click);
            // 
            // lbltit1
            // 
            this.lbltit1.AutoSize = true;
            this.lbltit1.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltit1.ForeColor = System.Drawing.Color.Maroon;
            this.lbltit1.Location = new System.Drawing.Point(644, 9);
            this.lbltit1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltit1.Name = "lbltit1";
            this.lbltit1.Size = new System.Drawing.Size(589, 64);
            this.lbltit1.TabIndex = 5;
            this.lbltit1.Text = "Cadena de Hoteles";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(689, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(490, 64);
            this.label1.TabIndex = 6;
            this.label1.Text = "Paraiso Eterno";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.cmdHabitaciones);
            this.panel1.Controls.Add(this.cmdHoteles);
            this.panel1.Controls.Add(this.cmdCategorias);
            this.panel1.Controls.Add(this.cmdReservaciones);
            this.panel1.Controls.Add(this.cmdClientes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(201, 687);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(206, 140);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1698, 901);
            this.panel2.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1155, 687);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbltit1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdClientes;
        private System.Windows.Forms.Button cmdReservaciones;
        private System.Windows.Forms.Button cmdHabitaciones;
        private System.Windows.Forms.Button cmdCategorias;
        private System.Windows.Forms.Button cmdHoteles;
        private System.Windows.Forms.Label lbltit1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

