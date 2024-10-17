
namespace clinica
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.cmdPaciente = new System.Windows.Forms.Button();
            this.cmdDoc = new System.Windows.Forms.Button();
            this.cmdReporte = new System.Windows.Forms.Button();
            this.cmdEmpleados = new System.Windows.Forms.Button();
            this.cmdUnidad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdPaciente
            // 
            this.cmdPaciente.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.cmdPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdPaciente.Location = new System.Drawing.Point(15, 12);
            this.cmdPaciente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdPaciente.Name = "cmdPaciente";
            this.cmdPaciente.Size = new System.Drawing.Size(441, 57);
            this.cmdPaciente.TabIndex = 0;
            this.cmdPaciente.Text = "Paciente";
            this.cmdPaciente.UseVisualStyleBackColor = true;
            this.cmdPaciente.Click += new System.EventHandler(this.cmdPaciente_Click);
            // 
            // cmdDoc
            // 
            this.cmdDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDoc.Location = new System.Drawing.Point(15, 245);
            this.cmdDoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdDoc.Name = "cmdDoc";
            this.cmdDoc.Size = new System.Drawing.Size(441, 57);
            this.cmdDoc.TabIndex = 1;
            this.cmdDoc.Text = "Doctor Responsable";
            this.cmdDoc.UseVisualStyleBackColor = true;
            this.cmdDoc.Click += new System.EventHandler(this.cmdDoc_Click);
            // 
            // cmdReporte
            // 
            this.cmdReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdReporte.Location = new System.Drawing.Point(15, 85);
            this.cmdReporte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdReporte.Name = "cmdReporte";
            this.cmdReporte.Size = new System.Drawing.Size(441, 57);
            this.cmdReporte.TabIndex = 2;
            this.cmdReporte.Text = "Reporte de seguimiento";
            this.cmdReporte.UseVisualStyleBackColor = true;
            this.cmdReporte.Click += new System.EventHandler(this.cmdReporte_Click);
            // 
            // cmdEmpleados
            // 
            this.cmdEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEmpleados.Location = new System.Drawing.Point(15, 165);
            this.cmdEmpleados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdEmpleados.Name = "cmdEmpleados";
            this.cmdEmpleados.Size = new System.Drawing.Size(441, 57);
            this.cmdEmpleados.TabIndex = 3;
            this.cmdEmpleados.Text = "Empleados";
            this.cmdEmpleados.UseVisualStyleBackColor = true;
            this.cmdEmpleados.Click += new System.EventHandler(this.cmdEmpleados_Click);
            // 
            // cmdUnidad
            // 
            this.cmdUnidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdUnidad.Location = new System.Drawing.Point(15, 331);
            this.cmdUnidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdUnidad.Name = "cmdUnidad";
            this.cmdUnidad.Size = new System.Drawing.Size(441, 57);
            this.cmdUnidad.TabIndex = 4;
            this.cmdUnidad.Text = "Unidad";
            this.cmdUnidad.UseVisualStyleBackColor = true;
            this.cmdUnidad.Click += new System.EventHandler(this.cmdUnidad_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 418);
            this.Controls.Add(this.cmdUnidad);
            this.Controls.Add(this.cmdEmpleados);
            this.Controls.Add(this.cmdReporte);
            this.Controls.Add(this.cmdDoc);
            this.Controls.Add(this.cmdPaciente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdPaciente;
        private System.Windows.Forms.Button cmdDoc;
        private System.Windows.Forms.Button cmdReporte;
        private System.Windows.Forms.Button cmdEmpleados;
        private System.Windows.Forms.Button cmdUnidad;
    }
}

