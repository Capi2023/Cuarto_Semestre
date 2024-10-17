
namespace Prac2
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
            this.components = new System.ComponentModel.Container();
            this.cmdBoton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // cmdBoton
            // 
            this.cmdBoton.BackColor = System.Drawing.SystemColors.Highlight;
            this.cmdBoton.Location = new System.Drawing.Point(193, 110);
            this.cmdBoton.Name = "cmdBoton";
            this.cmdBoton.Size = new System.Drawing.Size(81, 34);
            this.cmdBoton.TabIndex = 0;
            this.cmdBoton.Text = "Que vez";
            this.cmdBoton.UseVisualStyleBackColor = false;
            this.cmdBoton.Click += new System.EventHandler(this.cmdBoton_Click);
            this.cmdBoton.Paint += new System.Windows.Forms.PaintEventHandler(this.hm);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.Mover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(498, 251);
            this.Controls.Add(this.cmdBoton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.va);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdBoton;
        private System.Windows.Forms.Timer timer1;
    }
}

