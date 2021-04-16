
namespace alumnos
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
            this.ltbresultado = new System.Windows.Forms.ListBox();
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.btncargarArchivo = new System.Windows.Forms.Button();
            this.btnNombres = new System.Windows.Forms.Button();
            this.btngneralP1 = new System.Windows.Forms.Button();
            this.btngeneralP2 = new System.Windows.Forms.Button();
            this.btngeneralP3 = new System.Windows.Forms.Button();
            this.btNotamayor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PromedioAlumno = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ltbresultado
            // 
            this.ltbresultado.FormattingEnabled = true;
            this.ltbresultado.Location = new System.Drawing.Point(349, 12);
            this.ltbresultado.Name = "ltbresultado";
            this.ltbresultado.Size = new System.Drawing.Size(511, 147);
            this.ltbresultado.TabIndex = 1;
            // 
            // txtresultado
            // 
            this.txtresultado.Location = new System.Drawing.Point(12, 12);
            this.txtresultado.Multiline = true;
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtresultado.Size = new System.Drawing.Size(284, 147);
            this.txtresultado.TabIndex = 2;
            // 
            // btncargarArchivo
            // 
            this.btncargarArchivo.Location = new System.Drawing.Point(12, 180);
            this.btncargarArchivo.Name = "btncargarArchivo";
            this.btncargarArchivo.Size = new System.Drawing.Size(94, 57);
            this.btncargarArchivo.TabIndex = 3;
            this.btncargarArchivo.Text = "cargar Archivo";
            this.btncargarArchivo.UseVisualStyleBackColor = true;
            this.btncargarArchivo.Click += new System.EventHandler(this.btncargarArchivo_Click);
            // 
            // btnNombres
            // 
            this.btnNombres.Location = new System.Drawing.Point(349, 180);
            this.btnNombres.Name = "btnNombres";
            this.btnNombres.Size = new System.Drawing.Size(93, 66);
            this.btnNombres.TabIndex = 4;
            this.btnNombres.Text = "nombres";
            this.btnNombres.UseVisualStyleBackColor = true;
            this.btnNombres.Click += new System.EventHandler(this.btnNombres_Click);
            // 
            // btngneralP1
            // 
            this.btngneralP1.Location = new System.Drawing.Point(449, 180);
            this.btngneralP1.Name = "btngneralP1";
            this.btngneralP1.Size = new System.Drawing.Size(88, 66);
            this.btngneralP1.TabIndex = 5;
            this.btngneralP1.Text = "promedio general parcial 1";
            this.btngneralP1.UseVisualStyleBackColor = true;
            this.btngneralP1.Click += new System.EventHandler(this.btngneralP1_Click);
            // 
            // btngeneralP2
            // 
            this.btngeneralP2.Location = new System.Drawing.Point(543, 181);
            this.btngeneralP2.Name = "btngeneralP2";
            this.btngeneralP2.Size = new System.Drawing.Size(93, 65);
            this.btngeneralP2.TabIndex = 6;
            this.btngeneralP2.Text = "promedio general parcial 2";
            this.btngeneralP2.UseVisualStyleBackColor = true;
            this.btngeneralP2.Click += new System.EventHandler(this.btngeneralP2_Click);
            // 
            // btngeneralP3
            // 
            this.btngeneralP3.Location = new System.Drawing.Point(642, 180);
            this.btngeneralP3.Name = "btngeneralP3";
            this.btngeneralP3.Size = new System.Drawing.Size(98, 65);
            this.btngeneralP3.TabIndex = 7;
            this.btngeneralP3.Text = "promedio general parcial 3";
            this.btngeneralP3.UseVisualStyleBackColor = true;
            this.btngeneralP3.Click += new System.EventHandler(this.btngeneralP3_Click);
            // 
            // btNotamayor
            // 
            this.btNotamayor.Location = new System.Drawing.Point(747, 180);
            this.btNotamayor.Name = "btNotamayor";
            this.btNotamayor.Size = new System.Drawing.Size(100, 66);
            this.btNotamayor.TabIndex = 8;
            this.btNotamayor.Text = "nota mayor";
            this.btNotamayor.UseVisualStyleBackColor = true;
            this.btNotamayor.Click += new System.EventHandler(this.btNotamayor_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 66);
            this.label1.TabIndex = 9;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // PromedioAlumno
            // 
            this.PromedioAlumno.Location = new System.Drawing.Point(483, 265);
            this.PromedioAlumno.Name = "PromedioAlumno";
            this.PromedioAlumno.Size = new System.Drawing.Size(125, 66);
            this.PromedioAlumno.TabIndex = 10;
            this.PromedioAlumno.Text = "Promedio Por Alumno";
            this.PromedioAlumno.UseVisualStyleBackColor = true;
            this.PromedioAlumno.Click += new System.EventHandler(this.PromedioAlumno_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 450);
            this.Controls.Add(this.PromedioAlumno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btNotamayor);
            this.Controls.Add(this.btngeneralP3);
            this.Controls.Add(this.btngeneralP2);
            this.Controls.Add(this.btngneralP1);
            this.Controls.Add(this.btnNombres);
            this.Controls.Add(this.btncargarArchivo);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.ltbresultado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox ltbresultado;
        private System.Windows.Forms.TextBox txtresultado;
        private System.Windows.Forms.Button btncargarArchivo;
        private System.Windows.Forms.Button btnNombres;
        private System.Windows.Forms.Button btngneralP1;
        private System.Windows.Forms.Button btngeneralP2;
        private System.Windows.Forms.Button btngeneralP3;
        private System.Windows.Forms.Button btNotamayor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PromedioAlumno;
    }
}

