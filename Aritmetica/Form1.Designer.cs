
namespace Aritmetica
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
            this.cmdsuma = new System.Windows.Forms.Button();
            this.cmdresta = new System.Windows.Forms.Button();
            this.cmdmulti = new System.Windows.Forms.Button();
            this.cmddivision = new System.Windows.Forms.Button();
            this.txta = new System.Windows.Forms.TextBox();
            this.txtb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdsuma
            // 
            this.cmdsuma.Location = new System.Drawing.Point(60, 358);
            this.cmdsuma.Name = "cmdsuma";
            this.cmdsuma.Size = new System.Drawing.Size(75, 23);
            this.cmdsuma.TabIndex = 0;
            this.cmdsuma.Text = "Suma";
            this.cmdsuma.UseVisualStyleBackColor = true;
            this.cmdsuma.Click += new System.EventHandler(this.cmdsuma_Click);
            // 
            // cmdresta
            // 
            this.cmdresta.Location = new System.Drawing.Point(242, 358);
            this.cmdresta.Name = "cmdresta";
            this.cmdresta.Size = new System.Drawing.Size(75, 23);
            this.cmdresta.TabIndex = 1;
            this.cmdresta.Text = "Resta";
            this.cmdresta.UseVisualStyleBackColor = true;
            this.cmdresta.Click += new System.EventHandler(this.cmdresta_Click);
            // 
            // cmdmulti
            // 
            this.cmdmulti.Location = new System.Drawing.Point(443, 358);
            this.cmdmulti.Name = "cmdmulti";
            this.cmdmulti.Size = new System.Drawing.Size(105, 23);
            this.cmdmulti.TabIndex = 2;
            this.cmdmulti.Text = "Multiplicacion";
            this.cmdmulti.UseVisualStyleBackColor = true;
            this.cmdmulti.Click += new System.EventHandler(this.cmdmulti_Click);
            // 
            // cmddivision
            // 
            this.cmddivision.Location = new System.Drawing.Point(605, 358);
            this.cmddivision.Name = "cmddivision";
            this.cmddivision.Size = new System.Drawing.Size(75, 23);
            this.cmddivision.TabIndex = 3;
            this.cmddivision.Text = "Division";
            this.cmddivision.UseVisualStyleBackColor = true;
            this.cmddivision.Click += new System.EventHandler(this.cmddivision_Click);
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(60, 97);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(100, 22);
            this.txta.TabIndex = 4;
            // 
            // txtb
            // 
            this.txtb.Location = new System.Drawing.Point(403, 111);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(100, 22);
            this.txtb.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(283, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtb);
            this.Controls.Add(this.txta);
            this.Controls.Add(this.cmddivision);
            this.Controls.Add(this.cmdmulti);
            this.Controls.Add(this.cmdresta);
            this.Controls.Add(this.cmdsuma);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdsuma;
        private System.Windows.Forms.Button cmdresta;
        private System.Windows.Forms.Button cmdmulti;
        private System.Windows.Forms.Button cmddivision;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.Label label1;
    }
}

