
namespace Practica_Unidad1
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
            this.cmdBtn1 = new System.Windows.Forms.Button();
            this.cmdBtn2 = new System.Windows.Forms.Button();
            this.cmdBtn3 = new System.Windows.Forms.Button();
            this.cmdBtn4 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // cmdBtn1
            // 
            this.cmdBtn1.Location = new System.Drawing.Point(75, 49);
            this.cmdBtn1.Name = "cmdBtn1";
            this.cmdBtn1.Size = new System.Drawing.Size(75, 75);
            this.cmdBtn1.TabIndex = 0;
            this.cmdBtn1.Text = "1";
            this.cmdBtn1.UseVisualStyleBackColor = true;
            // 
            // cmdBtn2
            // 
            this.cmdBtn2.Location = new System.Drawing.Point(445, 84);
            this.cmdBtn2.Name = "cmdBtn2";
            this.cmdBtn2.Size = new System.Drawing.Size(75, 75);
            this.cmdBtn2.TabIndex = 1;
            this.cmdBtn2.Text = "2";
            this.cmdBtn2.UseVisualStyleBackColor = true;
            // 
            // cmdBtn3
            // 
            this.cmdBtn3.Location = new System.Drawing.Point(193, 226);
            this.cmdBtn3.Name = "cmdBtn3";
            this.cmdBtn3.Size = new System.Drawing.Size(75, 75);
            this.cmdBtn3.TabIndex = 2;
            this.cmdBtn3.Text = "3";
            this.cmdBtn3.UseVisualStyleBackColor = true;
            // 
            // cmdBtn4
            // 
            this.cmdBtn4.Location = new System.Drawing.Point(462, 259);
            this.cmdBtn4.Name = "cmdBtn4";
            this.cmdBtn4.Size = new System.Drawing.Size(75, 75);
            this.cmdBtn4.TabIndex = 3;
            this.cmdBtn4.Text = "4";
            this.cmdBtn4.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.Mover1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 523);
            this.Controls.Add(this.cmdBtn4);
            this.Controls.Add(this.cmdBtn3);
            this.Controls.Add(this.cmdBtn2);
            this.Controls.Add(this.cmdBtn1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Actualiza);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdBtn1;
        private System.Windows.Forms.Button cmdBtn2;
        private System.Windows.Forms.Button cmdBtn3;
        private System.Windows.Forms.Button cmdBtn4;
        private System.Windows.Forms.Timer timer1;
    }
}

