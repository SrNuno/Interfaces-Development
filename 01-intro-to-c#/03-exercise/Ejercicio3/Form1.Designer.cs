namespace Ejercicio3
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
            this.txtOne = new System.Windows.Forms.TextBox();
            this.txtTwo = new System.Windows.Forms.TextBox();
            this.txtThree = new System.Windows.Forms.TextBox();
            this.btnPress = new System.Windows.Forms.Button();
            this.lblReward = new System.Windows.Forms.Label();
            this.lblCredit = new System.Windows.Forms.Label();
            this.btnCredit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtOne
            // 
            this.txtOne.Enabled = false;
            this.txtOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 66F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOne.Location = new System.Drawing.Point(22, 28);
            this.txtOne.Name = "txtOne";
            this.txtOne.Size = new System.Drawing.Size(100, 107);
            this.txtOne.TabIndex = 0;
            this.txtOne.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTwo
            // 
            this.txtTwo.Enabled = false;
            this.txtTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 66F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTwo.Location = new System.Drawing.Point(143, 28);
            this.txtTwo.Name = "txtTwo";
            this.txtTwo.Size = new System.Drawing.Size(100, 107);
            this.txtTwo.TabIndex = 1;
            this.txtTwo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtThree
            // 
            this.txtThree.Enabled = false;
            this.txtThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 66F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThree.Location = new System.Drawing.Point(262, 28);
            this.txtThree.Name = "txtThree";
            this.txtThree.Size = new System.Drawing.Size(100, 107);
            this.txtThree.TabIndex = 2;
            this.txtThree.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnPress
            // 
            this.btnPress.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPress.Location = new System.Drawing.Point(22, 149);
            this.btnPress.Name = "btnPress";
            this.btnPress.Size = new System.Drawing.Size(340, 53);
            this.btnPress.TabIndex = 3;
            this.btnPress.Text = "PRESS";
            this.btnPress.UseVisualStyleBackColor = true;
            this.btnPress.Click += new System.EventHandler(this.btnPress_Click);
            // 
            // lblReward
            // 
            this.lblReward.AutoSize = true;
            this.lblReward.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReward.Location = new System.Drawing.Point(18, 295);
            this.lblReward.Name = "lblReward";
            this.lblReward.Size = new System.Drawing.Size(175, 24);
            this.lblReward.TabIndex = 4;
            this.lblReward.Text = "Reward/No Reward";
            // 
            // lblCredit
            // 
            this.lblCredit.AutoSize = true;
            this.lblCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCredit.Location = new System.Drawing.Point(276, 298);
            this.lblCredit.Name = "lblCredit";
            this.lblCredit.Size = new System.Drawing.Size(86, 20);
            this.lblCredit.TabIndex = 5;
            this.lblCredit.Text = "Credit: 50€";
            // 
            // btnCredit
            // 
            this.btnCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCredit.Location = new System.Drawing.Point(22, 331);
            this.btnCredit.Name = "btnCredit";
            this.btnCredit.Size = new System.Drawing.Size(340, 41);
            this.btnCredit.TabIndex = 6;
            this.btnCredit.Text = "NEW CREDIT";
            this.btnCredit.UseVisualStyleBackColor = true;
            this.btnCredit.Click += new System.EventHandler(this.btnCredit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 393);
            this.Controls.Add(this.btnCredit);
            this.Controls.Add(this.lblCredit);
            this.Controls.Add(this.lblReward);
            this.Controls.Add(this.btnPress);
            this.Controls.Add(this.txtThree);
            this.Controls.Add(this.txtTwo);
            this.Controls.Add(this.txtOne);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOne;
        private System.Windows.Forms.TextBox txtTwo;
        private System.Windows.Forms.TextBox txtThree;
        private System.Windows.Forms.Button btnPress;
        private System.Windows.Forms.Label lblReward;
        private System.Windows.Forms.Label lblCredit;
        private System.Windows.Forms.Button btnCredit;
    }
}

