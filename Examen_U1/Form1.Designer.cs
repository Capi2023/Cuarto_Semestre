
namespace Examen_U1
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
            this.cmdBtn1.Location = new System.Drawing.Point(138, 92);
            this.cmdBtn1.Name = "cmdBtn1";
            this.cmdBtn1.Size = new System.Drawing.Size(75, 23);
            this.cmdBtn1.TabIndex = 0;
            this.cmdBtn1.Text = "Fast";
            this.cmdBtn1.UseVisualStyleBackColor = true;
            this.cmdBtn1.Click += new System.EventHandler(this.cmdBtn1_Click);
            // 
            // cmdBtn2
            // 
            this.cmdBtn2.Location = new System.Drawing.Point(553, 101);
            this.cmdBtn2.Name = "cmdBtn2";
            this.cmdBtn2.Size = new System.Drawing.Size(75, 23);
            this.cmdBtn2.TabIndex = 1;
            this.cmdBtn2.Text = "Color";
            this.cmdBtn2.UseVisualStyleBackColor = true;
            this.cmdBtn2.Click += new System.EventHandler(this.cmdBtn2_Click);
            // 
            // cmdBtn3
            // 
            this.cmdBtn3.Location = new System.Drawing.Point(314, 253);
            this.cmdBtn3.Name = "cmdBtn3";
            this.cmdBtn3.Size = new System.Drawing.Size(75, 23);
            this.cmdBtn3.TabIndex = 2;
            this.cmdBtn3.Text = "Se mueve";
            this.cmdBtn3.UseVisualStyleBackColor = true;
            this.cmdBtn3.Click += new System.EventHandler(this.cmdBtn3_Click);
            // 
            // cmdBtn4
            // 
            this.cmdBtn4.Location = new System.Drawing.Point(304, 145);
            this.cmdBtn4.Name = "cmdBtn4";
            this.cmdBtn4.Size = new System.Drawing.Size(75, 23);
            this.cmdBtn4.TabIndex = 3;
            this.cmdBtn4.Text = "Cerrar";
            this.cmdBtn4.UseVisualStyleBackColor = true;
            this.cmdBtn4.Click += new System.EventHandler(this.cmdBtn4_Click);
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
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdBtn4);
            this.Controls.Add(this.cmdBtn3);
            this.Controls.Add(this.cmdBtn2);
            this.Controls.Add(this.cmdBtn1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Iniciar);
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

