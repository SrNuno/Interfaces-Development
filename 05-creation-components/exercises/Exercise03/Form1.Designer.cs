namespace Exercise03
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
            this.repSimple = new ControlLibrary.ReproSimple();
            this.SuspendLayout();
            // 
            // repSimple
            // 
            this.repSimple.Location = new System.Drawing.Point(12, 10);
            this.repSimple.Name = "repSimple";
            this.repSimple.Size = new System.Drawing.Size(350, 346);
            this.repSimple.TabIndex = 0;
            this.repSimple.PlayClick += new System.EventHandler(this.repSimple_PlayClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 368);
            this.Controls.Add(this.repSimple);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ControlLibrary.ReproSimple repSimple;
    }
}

