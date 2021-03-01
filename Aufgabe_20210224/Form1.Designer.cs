namespace Aufgabe_20210224 {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnGroesser = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnGausz = new System.Windows.Forms.Button();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.tb3 = new System.Windows.Forms.TextBox();
            this.lblOutA = new System.Windows.Forms.Label();
            this.lblOutB = new System.Windows.Forms.Label();
            this.lblOutC = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnGroesser
            // 
            this.btnGroesser.Enabled = false;
            this.btnGroesser.Location = new System.Drawing.Point(62, 189);
            this.btnGroesser.Name = "btnGroesser";
            this.btnGroesser.Size = new System.Drawing.Size(75, 23);
            this.btnGroesser.TabIndex = 0;
            this.btnGroesser.Text = "Int > <";
            this.btnGroesser.UseVisualStyleBackColor = true;
            this.btnGroesser.Click += new System.EventHandler(this.btnGroesser_Click);
            // 
            // btnSort
            // 
            this.btnSort.Enabled = false;
            this.btnSort.Location = new System.Drawing.Point(192, 189);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(75, 23);
            this.btnSort.TabIndex = 0;
            this.btnSort.Text = "Sort. Int";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnGausz
            // 
            this.btnGausz.Enabled = false;
            this.btnGausz.Location = new System.Drawing.Point(322, 189);
            this.btnGausz.Name = "btnGausz";
            this.btnGausz.Size = new System.Drawing.Size(75, 23);
            this.btnGausz.TabIndex = 0;
            this.btnGausz.Text = "Gauß";
            this.btnGausz.UseVisualStyleBackColor = true;
            this.btnGausz.Click += new System.EventHandler(this.btnGausz_Click);
            // 
            // tb1
            // 
            this.tb1.Enabled = false;
            this.tb1.Location = new System.Drawing.Point(62, 137);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(100, 23);
            this.tb1.TabIndex = 1;
            // 
            // tb2
            // 
            this.tb2.Enabled = false;
            this.tb2.Location = new System.Drawing.Point(180, 137);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(100, 23);
            this.tb2.TabIndex = 1;
            // 
            // tb3
            // 
            this.tb3.Enabled = false;
            this.tb3.Location = new System.Drawing.Point(298, 137);
            this.tb3.Name = "tb3";
            this.tb3.Size = new System.Drawing.Size(100, 23);
            this.tb3.TabIndex = 1;
            // 
            // lblOutA
            // 
            this.lblOutA.AutoSize = true;
            this.lblOutA.Location = new System.Drawing.Point(227, 27);
            this.lblOutA.Name = "lblOutA";
            this.lblOutA.Size = new System.Drawing.Size(0, 15);
            this.lblOutA.TabIndex = 2;
            // 
            // lblOutB
            // 
            this.lblOutB.AutoSize = true;
            this.lblOutB.Location = new System.Drawing.Point(227, 60);
            this.lblOutB.Name = "lblOutB";
            this.lblOutB.Size = new System.Drawing.Size(0, 15);
            this.lblOutB.TabIndex = 2;
            // 
            // lblOutC
            // 
            this.lblOutC.AutoSize = true;
            this.lblOutC.Location = new System.Drawing.Point(227, 93);
            this.lblOutC.Name = "lblOutC";
            this.lblOutC.Size = new System.Drawing.Size(0, 15);
            this.lblOutC.TabIndex = 2;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(62, 27);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(135, 19);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "2 Zahlen vergleichen";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(62, 60);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(120, 19);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "3 Zahlen sortieren";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(62, 93);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(127, 19);
            this.checkBox3.TabIndex = 3;
            this.checkBox3.Text = "Gaußsche Addition";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 249);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lblOutC);
            this.Controls.Add(this.lblOutB);
            this.Controls.Add(this.lblOutA);
            this.Controls.Add(this.tb3);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.btnGausz);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnGroesser);
            this.Name = "Form1";
            this.Text = "ProgrammEinZ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnGausz;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblOutA;
        private System.Windows.Forms.Label lblOutB;
        private System.Windows.Forms.Label lblOutC;
        private System.Windows.Forms.TextBox tb3;
        private System.Windows.Forms.Button btnGroesser;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
    }
}

