
namespace Practica_3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cmdBoton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.cmdBtn1 = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.cmdBtn2 = new System.Windows.Forms.Button();
            this.cmdBtn3 = new System.Windows.Forms.Button();
            this.cmdBtn4 = new System.Windows.Forms.Button();
            this.cmdBtn5 = new System.Windows.Forms.Button();
            this.pct3 = new System.Windows.Forms.PictureBox();
            this.pct2 = new System.Windows.Forms.PictureBox();
            this.pct1 = new System.Windows.Forms.PictureBox();
            this.lbladios = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pct3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdBoton
            // 
            this.cmdBoton.Location = new System.Drawing.Point(379, 183);
            this.cmdBoton.Name = "cmdBoton";
            this.cmdBoton.Size = new System.Drawing.Size(25, 23);
            this.cmdBoton.TabIndex = 0;
            this.cmdBoton.UseVisualStyleBackColor = true;
            this.cmdBoton.Click += new System.EventHandler(this.cmdBoton_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.Mover);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(135, 65);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(0, 13);
            this.lbl1.TabIndex = 1;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(633, 329);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(0, 13);
            this.lbl2.TabIndex = 2;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(364, 220);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(0, 13);
            this.lbl3.TabIndex = 3;
            // 
            // cmdBtn1
            // 
            this.cmdBtn1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdBtn1.Location = new System.Drawing.Point(615, 103);
            this.cmdBtn1.Name = "cmdBtn1";
            this.cmdBtn1.Size = new System.Drawing.Size(75, 23);
            this.cmdBtn1.TabIndex = 4;
            this.cmdBtn1.UseVisualStyleBackColor = false;
            this.cmdBtn1.Visible = false;
            this.cmdBtn1.Click += new System.EventHandler(this.cmdBtn1_Click);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // cmdBtn2
            // 
            this.cmdBtn2.BackColor = System.Drawing.Color.Blue;
            this.cmdBtn2.Location = new System.Drawing.Point(713, 12);
            this.cmdBtn2.Name = "cmdBtn2";
            this.cmdBtn2.Size = new System.Drawing.Size(75, 23);
            this.cmdBtn2.TabIndex = 5;
            this.cmdBtn2.UseVisualStyleBackColor = false;
            this.cmdBtn2.Visible = false;
            // 
            // cmdBtn3
            // 
            this.cmdBtn3.BackColor = System.Drawing.Color.Purple;
            this.cmdBtn3.Location = new System.Drawing.Point(82, 369);
            this.cmdBtn3.Name = "cmdBtn3";
            this.cmdBtn3.Size = new System.Drawing.Size(75, 23);
            this.cmdBtn3.TabIndex = 6;
            this.cmdBtn3.UseVisualStyleBackColor = false;
            this.cmdBtn3.Visible = false;
            // 
            // cmdBtn4
            // 
            this.cmdBtn4.BackColor = System.Drawing.Color.Lime;
            this.cmdBtn4.Location = new System.Drawing.Point(587, 359);
            this.cmdBtn4.Name = "cmdBtn4";
            this.cmdBtn4.Size = new System.Drawing.Size(75, 23);
            this.cmdBtn4.TabIndex = 7;
            this.cmdBtn4.UseVisualStyleBackColor = false;
            this.cmdBtn4.Visible = false;
            // 
            // cmdBtn5
            // 
            this.cmdBtn5.BackColor = System.Drawing.Color.Red;
            this.cmdBtn5.Location = new System.Drawing.Point(452, 286);
            this.cmdBtn5.Name = "cmdBtn5";
            this.cmdBtn5.Size = new System.Drawing.Size(75, 23);
            this.cmdBtn5.TabIndex = 8;
            this.cmdBtn5.UseVisualStyleBackColor = false;
            this.cmdBtn5.Visible = false;
            // 
            // pct3
            // 
            this.pct3.Image = global::Practica_3.Properties.Resources._275127278_1013812876011021_8012463563577861153_n;
            this.pct3.Location = new System.Drawing.Point(32, 103);
            this.pct3.Name = "pct3";
            this.pct3.Size = new System.Drawing.Size(103, 110);
            this.pct3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pct3.TabIndex = 11;
            this.pct3.TabStop = false;
            this.pct3.Visible = false;
            // 
            // pct2
            // 
            this.pct2.Image = global::Practica_3.Properties.Resources._275101441_304647571737327_84970176269980088_n;
            this.pct2.Location = new System.Drawing.Point(600, 183);
            this.pct2.Name = "pct2";
            this.pct2.Size = new System.Drawing.Size(178, 143);
            this.pct2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pct2.TabIndex = 10;
            this.pct2.TabStop = false;
            this.pct2.Visible = false;
            // 
            // pct1
            // 
            this.pct1.ErrorImage = null;
            this.pct1.Image = global::Practica_3.Properties.Resources._275092639_995242224734549_9189433628285437093_n;
            this.pct1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pct1.InitialImage")));
            this.pct1.Location = new System.Drawing.Point(388, 28);
            this.pct1.Name = "pct1";
            this.pct1.Size = new System.Drawing.Size(139, 98);
            this.pct1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pct1.TabIndex = 9;
            this.pct1.TabStop = false;
            this.pct1.Visible = false;
            // 
            // lbladios
            // 
            this.lbladios.AutoSize = true;
            this.lbladios.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladios.Location = new System.Drawing.Point(275, 187);
            this.lbladios.Name = "lbladios";
            this.lbladios.Size = new System.Drawing.Size(0, 55);
            this.lbladios.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbladios);
            this.Controls.Add(this.pct3);
            this.Controls.Add(this.pct2);
            this.Controls.Add(this.pct1);
            this.Controls.Add(this.cmdBtn5);
            this.Controls.Add(this.cmdBtn4);
            this.Controls.Add(this.cmdBtn3);
            this.Controls.Add(this.cmdBtn2);
            this.Controls.Add(this.cmdBtn1);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.cmdBoton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.va);
            ((System.ComponentModel.ISupportInitialize)(this.pct3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdBoton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Button cmdBtn1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button cmdBtn2;
        private System.Windows.Forms.Button cmdBtn3;
        private System.Windows.Forms.Button cmdBtn4;
        private System.Windows.Forms.Button cmdBtn5;
        private System.Windows.Forms.PictureBox pct1;
        private System.Windows.Forms.PictureBox pct2;
        private System.Windows.Forms.PictureBox pct3;
        private System.Windows.Forms.Label lbladios;
    }
}

