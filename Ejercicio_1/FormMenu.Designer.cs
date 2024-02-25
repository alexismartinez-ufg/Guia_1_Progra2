namespace Ejercicio_1
{
    partial class FormMenu
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
            this.btnAgregarEstudiantes = new System.Windows.Forms.Button();
            this.btnReporteEstudiantes = new System.Windows.Forms.Button();
            this.btnListadoEstudiantes = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarEstudiantes
            // 
            this.btnAgregarEstudiantes.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarEstudiantes.Location = new System.Drawing.Point(105, 75);
            this.btnAgregarEstudiantes.Name = "btnAgregarEstudiantes";
            this.btnAgregarEstudiantes.Size = new System.Drawing.Size(239, 48);
            this.btnAgregarEstudiantes.TabIndex = 0;
            this.btnAgregarEstudiantes.Text = "Ingresar datos de nuevo estudiante";
            this.btnAgregarEstudiantes.UseVisualStyleBackColor = true;
            this.btnAgregarEstudiantes.Click += new System.EventHandler(this.btnAgregarEstudiantes_Click);
            // 
            // btnReporteEstudiantes
            // 
            this.btnReporteEstudiantes.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteEstudiantes.Location = new System.Drawing.Point(105, 227);
            this.btnReporteEstudiantes.Name = "btnReporteEstudiantes";
            this.btnReporteEstudiantes.Size = new System.Drawing.Size(239, 48);
            this.btnReporteEstudiantes.TabIndex = 1;
            this.btnReporteEstudiantes.Text = "Reporte de estudiantes";
            this.btnReporteEstudiantes.UseVisualStyleBackColor = true;
            this.btnReporteEstudiantes.Click += new System.EventHandler(this.btnReporteEstudiantes_Click);
            // 
            // btnListadoEstudiantes
            // 
            this.btnListadoEstudiantes.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListadoEstudiantes.Location = new System.Drawing.Point(105, 151);
            this.btnListadoEstudiantes.Name = "btnListadoEstudiantes";
            this.btnListadoEstudiantes.Size = new System.Drawing.Size(239, 48);
            this.btnListadoEstudiantes.TabIndex = 2;
            this.btnListadoEstudiantes.Text = "Ver listado de estudiantes inscritos";
            this.btnListadoEstudiantes.UseVisualStyleBackColor = true;
            this.btnListadoEstudiantes.Click += new System.EventHandler(this.btnListadoEstudiantes_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(105, 303);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(239, 48);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "Control de Usuarios";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ejercicio_1.Properties.Resources.user_plus_solid;
            this.pictureBox1.Location = new System.Drawing.Point(52, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Ejercicio_1.Properties.Resources.list_check_solid;
            this.pictureBox2.Location = new System.Drawing.Point(52, 158);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Ejercicio_1.Properties.Resources.address_book_solid;
            this.pictureBox3.Location = new System.Drawing.Point(52, 234);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 35);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Ejercicio_1.Properties.Resources.right_from_bracket_solid;
            this.pictureBox4.Location = new System.Drawing.Point(52, 310);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(35, 35);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 368);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnListadoEstudiantes);
            this.Controls.Add(this.btnReporteEstudiantes);
            this.Controls.Add(this.btnAgregarEstudiantes);
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de Estudiantes";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarEstudiantes;
        private System.Windows.Forms.Button btnReporteEstudiantes;
        private System.Windows.Forms.Button btnListadoEstudiantes;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

