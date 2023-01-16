namespace FormExercise01
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
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.labelTextBox1 = new LibraryExercise01.LabelTextBox();
            this.etiquetaAviso1 = new LibraryExercise01.EtiquetaAviso();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(13, 39);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 23);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "Cambio";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(94, 39);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 23);
            this.btn2.TabIndex = 3;
            this.btn2.Text = "Separa";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // labelTextBox1
            // 
            this.labelTextBox1.Location = new System.Drawing.Point(13, 13);
            this.labelTextBox1.Name = "labelTextBox1";
            this.labelTextBox1.Posicion = LibraryExercise01.LabelTextBox.ePosicion.Derecha;
            this.labelTextBox1.PswChr = 'ç';
            this.labelTextBox1.Separacion = 0;
            this.labelTextBox1.Size = new System.Drawing.Size(338, 20);
            this.labelTextBox1.TabIndex = 2;
            this.labelTextBox1.PosicionChanged += new System.EventHandler(this.labelTextBox1_PosicionChanged);
            this.labelTextBox1.SeparacionChanged += new System.EventHandler(this.labelTextBox1_SeparacionChanged);
            this.labelTextBox1.TxtChanged += new System.EventHandler(this.labelTextBox1_TxtChanged);
            this.labelTextBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.labelTextBox1_KeyUp);
            // 
            // etiquetaAviso1
            // 
            this.etiquetaAviso1.Color = System.Drawing.Color.DodgerBlue;
            this.etiquetaAviso1.ColorSecond = System.Drawing.Color.Red;
            this.etiquetaAviso1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiquetaAviso1.ForeColor = System.Drawing.Color.White;
            this.etiquetaAviso1.Gradient = true;
            this.etiquetaAviso1.Location = new System.Drawing.Point(13, 68);
            this.etiquetaAviso1.Marca = LibraryExercise01.EtiquetaAviso.eMarca.Nada;
            this.etiquetaAviso1.Name = "etiquetaAviso1";
            this.etiquetaAviso1.Size = new System.Drawing.Size(454, 80);
            this.etiquetaAviso1.TabIndex = 4;
            this.etiquetaAviso1.Text = "etiquetaAviso1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 160);
            this.Controls.Add(this.etiquetaAviso1);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.labelTextBox1);
            this.Controls.Add(this.btn1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn1;
        private LibraryExercise01.LabelTextBox labelTextBox1;
        private System.Windows.Forms.Button btn2;
        private LibraryExercise01.EtiquetaAviso etiquetaAviso1;
    }
}

