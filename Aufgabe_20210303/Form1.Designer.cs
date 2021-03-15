namespace Aufgabe_20210303 {
    partial class Aufgabe_20210303 {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent() {
            this.tb_Zahl_1 = new System.Windows.Forms.TextBox();
            this.tb_Zahl_2 = new System.Windows.Forms.TextBox();
            this.tb_Zahl_3 = new System.Windows.Forms.TextBox();
            this.tb_Zahl_4 = new System.Windows.Forms.TextBox();
            this.tb_Zahl_5 = new System.Windows.Forms.TextBox();
            this.lbl_Ausgabe = new System.Windows.Forms.Label();
            this.btn_Ausgabe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_Zahl_1
            // 
            this.tb_Zahl_1.Location = new System.Drawing.Point(12, 12);
            this.tb_Zahl_1.Name = "tb_Zahl_1";
            this.tb_Zahl_1.Size = new System.Drawing.Size(100, 20);
            this.tb_Zahl_1.TabIndex = 1;
            // 
            // tb_Zahl_2
            // 
            this.tb_Zahl_2.Location = new System.Drawing.Point(12, 38);
            this.tb_Zahl_2.Name = "tb_Zahl_2";
            this.tb_Zahl_2.Size = new System.Drawing.Size(100, 20);
            this.tb_Zahl_2.TabIndex = 2;
            // 
            // tb_Zahl_3
            // 
            this.tb_Zahl_3.Location = new System.Drawing.Point(12, 64);
            this.tb_Zahl_3.Name = "tb_Zahl_3";
            this.tb_Zahl_3.Size = new System.Drawing.Size(100, 20);
            this.tb_Zahl_3.TabIndex = 3;
            // 
            // tb_Zahl_4
            // 
            this.tb_Zahl_4.Location = new System.Drawing.Point(12, 90);
            this.tb_Zahl_4.Name = "tb_Zahl_4";
            this.tb_Zahl_4.Size = new System.Drawing.Size(100, 20);
            this.tb_Zahl_4.TabIndex = 4;
            // 
            // tb_Zahl_5
            // 
            this.tb_Zahl_5.Location = new System.Drawing.Point(12, 116);
            this.tb_Zahl_5.Name = "tb_Zahl_5";
            this.tb_Zahl_5.Size = new System.Drawing.Size(100, 20);
            this.tb_Zahl_5.TabIndex = 5;
            // 
            // lbl_Ausgabe
            // 
            this.lbl_Ausgabe.AutoSize = true;
            this.lbl_Ausgabe.Location = new System.Drawing.Point(12, 157);
            this.lbl_Ausgabe.Name = "lbl_Ausgabe";
            this.lbl_Ausgabe.Size = new System.Drawing.Size(0, 13);
            this.lbl_Ausgabe.TabIndex = 6;
            // 
            // btn_Ausgabe
            // 
            this.btn_Ausgabe.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.btn_Ausgabe.Location = new System.Drawing.Point(161, 12);
            this.btn_Ausgabe.Name = "btn_Ausgabe";
            this.btn_Ausgabe.Size = new System.Drawing.Size(75, 23);
            this.btn_Ausgabe.TabIndex = 7;
            this.btn_Ausgabe.Text = "Ausgabe";
            this.btn_Ausgabe.UseVisualStyleBackColor = true;
            this.btn_Ausgabe.Click += new System.EventHandler(this.btn_Ausgabe_Click);
            // 
            // Aufgabe_20210303
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 204);
            this.Controls.Add(this.btn_Ausgabe);
            this.Controls.Add(this.lbl_Ausgabe);
            this.Controls.Add(this.tb_Zahl_5);
            this.Controls.Add(this.tb_Zahl_4);
            this.Controls.Add(this.tb_Zahl_3);
            this.Controls.Add(this.tb_Zahl_2);
            this.Controls.Add(this.tb_Zahl_1);
            this.Name = "Aufgabe_20210303";
            this.Text = "Aufgabe_20210303";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Zahl_1;
        private System.Windows.Forms.TextBox tb_Zahl_2;
        private System.Windows.Forms.TextBox tb_Zahl_3;
        private System.Windows.Forms.TextBox tb_Zahl_4;
        private System.Windows.Forms.TextBox tb_Zahl_5;
        private System.Windows.Forms.Label lbl_Ausgabe;
        private System.Windows.Forms.Button btn_Ausgabe;
    }
}

