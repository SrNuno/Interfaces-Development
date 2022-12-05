namespace Ejercicio5
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonTraspLeftRight = new System.Windows.Forms.Button();
            this.buttonTraspRightLeft = new System.Windows.Forms.Button();
            this.labelCantLB1 = new System.Windows.Forms.Label();
            this.labelCantLB2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter option:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(552, 20);
            this.textBox1.TabIndex = 1;
            this.toolTip1.SetToolTip(this.textBox1, "Enter option to add list left");
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 51);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(172, 173);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.Enter += new System.EventHandler(this.listBox1_Enter);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(392, 51);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(172, 173);
            this.listBox2.TabIndex = 3;
            this.listBox2.Enter += new System.EventHandler(this.listBox2_Enter);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(190, 51);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(196, 39);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Add";
            this.toolTip1.SetToolTip(this.buttonAdd, "Add text to list left");
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(190, 96);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(196, 39);
            this.buttonRemove.TabIndex = 5;
            this.buttonRemove.Text = "Remove";
            this.toolTip1.SetToolTip(this.buttonRemove, "Remove selected option from left list\r\n");
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonTraspLeftRight
            // 
            this.buttonTraspLeftRight.Location = new System.Drawing.Point(190, 140);
            this.buttonTraspLeftRight.Name = "buttonTraspLeftRight";
            this.buttonTraspLeftRight.Size = new System.Drawing.Size(196, 39);
            this.buttonTraspLeftRight.TabIndex = 6;
            this.buttonTraspLeftRight.Text = ">";
            this.toolTip1.SetToolTip(this.buttonTraspLeftRight, "Move option selected from left to right");
            this.buttonTraspLeftRight.UseVisualStyleBackColor = true;
            this.buttonTraspLeftRight.Click += new System.EventHandler(this.buttonTraspLeftRight_Click);
            // 
            // buttonTraspRightLeft
            // 
            this.buttonTraspRightLeft.Location = new System.Drawing.Point(190, 185);
            this.buttonTraspRightLeft.Name = "buttonTraspRightLeft";
            this.buttonTraspRightLeft.Size = new System.Drawing.Size(196, 39);
            this.buttonTraspRightLeft.TabIndex = 7;
            this.buttonTraspRightLeft.Text = "<";
            this.toolTip1.SetToolTip(this.buttonTraspRightLeft, "Move option selected from right to left\r\n");
            this.buttonTraspRightLeft.UseVisualStyleBackColor = true;
            this.buttonTraspRightLeft.Click += new System.EventHandler(this.buttonTraspRightLeft_Click);
            // 
            // labelCantLB1
            // 
            this.labelCantLB1.AutoSize = true;
            this.labelCantLB1.Location = new System.Drawing.Point(12, 227);
            this.labelCantLB1.Name = "labelCantLB1";
            this.labelCantLB1.Size = new System.Drawing.Size(47, 13);
            this.labelCantLB1.TabIndex = 8;
            this.labelCantLB1.Text = "Count: 0";
            this.toolTip1.SetToolTip(this.labelCantLB1, "Counter of all options to list left\r\n");
            // 
            // labelCantLB2
            // 
            this.labelCantLB2.AutoSize = true;
            this.labelCantLB2.Location = new System.Drawing.Point(392, 227);
            this.labelCantLB2.Name = "labelCantLB2";
            this.labelCantLB2.Size = new System.Drawing.Size(65, 13);
            this.labelCantLB2.TabIndex = 9;
            this.labelCantLB2.Text = "Index: None";
            this.toolTip1.SetToolTip(this.labelCantLB2, "Shows the selected indices from the list on the left");
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AcceptButton = this.buttonAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 253);
            this.Controls.Add(this.labelCantLB2);
            this.Controls.Add(this.labelCantLB1);
            this.Controls.Add(this.buttonTraspRightLeft);
            this.Controls.Add(this.buttonTraspLeftRight);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ListBox Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonTraspLeftRight;
        private System.Windows.Forms.Button buttonTraspRightLeft;
        private System.Windows.Forms.Label labelCantLB1;
        private System.Windows.Forms.Label labelCantLB2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

