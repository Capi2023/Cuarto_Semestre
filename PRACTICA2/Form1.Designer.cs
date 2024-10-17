
namespace PRACTICA2
{
    partial class PRACTICA2
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
            this.components = new System.ComponentModel.Container();
            this.cmdBoton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // cmdBoton
            // 
            this.cmdBoton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cmdBoton.Location = new System.Drawing.Point(352, 182);
            this.cmdBoton.Name = "cmdBoton";
            this.cmdBoton.Size = new System.Drawing.Size(98, 51);
            this.cmdBoton.TabIndex = 0;
            this.cmdBoton.Text = "Tocame ;P";
            this.cmdBoton.UseVisualStyleBackColor = false;
            this.cmdBoton.Click += new System.EventHandler(this.cmdBoton_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.Move);
            // 
            // PRACTICA2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdBoton);
            this.Name = "PRACTICA2";
            this.Text = "Boton en movimiento";
            this.Load += new System.EventHandler(this.PRACTICA2_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Paicmd);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdBoton;
        private System.Windows.Forms.Timer timer1;
    }
}

