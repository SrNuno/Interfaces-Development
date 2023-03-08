namespace Exercise05
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
            this.chk = new System.Windows.Forms.CheckBox();
            this.btn = new System.Windows.Forms.Button();
            this.validateTextBox1 = new ControlLibrary.ValidateTextBox();
            this.SuspendLayout();
            // 
            // chk
            // 
            this.chk.AutoSize = true;
            this.chk.Location = new System.Drawing.Point(12, 58);
            this.chk.Name = "chk";
            this.chk.Size = new System.Drawing.Size(72, 17);
            this.chk.TabIndex = 1;
            this.chk.Text = "Multilínea";
            this.chk.UseVisualStyleBackColor = true;
            this.chk.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(191, 131);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(83, 37);
            this.btn.TabIndex = 2;
            this.btn.Text = "Textual";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // validateTextBox1
            // 
            this.validateTextBox1.Location = new System.Drawing.Point(12, 12);
            this.validateTextBox1.Multilinea = false;
            this.validateTextBox1.Name = "validateTextBox1";
            this.validateTextBox1.Size = new System.Drawing.Size(494, 40);
            this.validateTextBox1.TabIndex = 3;
            this.validateTextBox1.Texto = "";
            this.validateTextBox1.Tipo = ControlLibrary.eTipo.Textual;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 180);
            this.Controls.Add(this.validateTextBox1);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.chk);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox chk;
        private System.Windows.Forms.Button btn;
        private ControlLibrary.ValidateTextBox validateTextBox1;
    }
}

