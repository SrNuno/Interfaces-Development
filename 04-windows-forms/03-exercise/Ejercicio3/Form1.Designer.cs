namespace Ejercicio3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnNewImage = new System.Windows.Forms.Button();
            this.dialogNewImage = new System.Windows.Forms.OpenFileDialog();
            this.chkModal = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnNewImage
            // 
            this.btnNewImage.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewImage.Location = new System.Drawing.Point(12, 12);
            this.btnNewImage.Name = "btnNewImage";
            this.btnNewImage.Size = new System.Drawing.Size(306, 30);
            this.btnNewImage.TabIndex = 0;
            this.btnNewImage.Text = "New Image";
            this.btnNewImage.UseVisualStyleBackColor = true;
            this.btnNewImage.Click += new System.EventHandler(this.btnNewImage_Click);
            // 
            // dialogNewImage
            // 
            this.dialogNewImage.Filter = "Archivos PNG(*.png)|*.png|Archivos JPG(*.jpg)|*.jpg|Archivos ICO(*.ico)|*.ico|Tod" +
    "os los archivos(*.*)|*.*";
            this.dialogNewImage.Title = "Choose Image";
            // 
            // chkModal
            // 
            this.chkModal.AutoSize = true;
            this.chkModal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkModal.Location = new System.Drawing.Point(12, 48);
            this.chkModal.Name = "chkModal";
            this.chkModal.Size = new System.Drawing.Size(64, 20);
            this.chkModal.TabIndex = 1;
            this.chkModal.Text = "Modal";
            this.chkModal.UseVisualStyleBackColor = true;
            this.chkModal.CheckedChanged += new System.EventHandler(this.chkModal_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 99);
            this.Controls.Add(this.chkModal);
            this.Controls.Add(this.btnNewImage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Images Visor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewImage;
        private System.Windows.Forms.OpenFileDialog dialogNewImage;
        private System.Windows.Forms.CheckBox chkModal;
    }
}

