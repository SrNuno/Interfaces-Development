namespace Exercise04
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ahorcado1 = new ControlLibrary.Ahorcado();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Incrementar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(174, 378);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 37);
            this.button2.TabIndex = 2;
            this.button2.Text = "Disminuír";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ahorcado1
            // 
            this.ahorcado1.Errores = 0;
            this.ahorcado1.Location = new System.Drawing.Point(12, 29);
            this.ahorcado1.Name = "ahorcado1";
            this.ahorcado1.Size = new System.Drawing.Size(314, 342);
            this.ahorcado1.TabIndex = 0;
            this.ahorcado1.CambiaError += new System.EventHandler(this.ahorcado1_CambiaError);
            this.ahorcado1.Ahorcad0 += new System.EventHandler(this.ahorcado1_Ahorcad0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Errores: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 427);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ahorcado1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControlLibrary.Ahorcado ahorcado1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}

