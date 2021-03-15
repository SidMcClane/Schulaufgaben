namespace Aufgabe_20210310 {
    partial class Form1 {
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
            this.tb_Array_Größe = new System.Windows.Forms.TextBox();
            this.tb_Array_Füllen = new System.Windows.Forms.TextBox();
            this.btn_Array_Größe = new System.Windows.Forms.Button();
            this.btn_Eingabe = new System.Windows.Forms.Button();
            this.btn_Ausgabe = new System.Windows.Forms.Button();
            this.lbl_Ausgabe = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_Array_Größe
            // 
            this.tb_Array_Größe.Location = new System.Drawing.Point(12, 36);
            this.tb_Array_Größe.Name = "tb_Array_Größe";
            this.tb_Array_Größe.Size = new System.Drawing.Size(100, 20);
            this.tb_Array_Größe.TabIndex = 0;
            // 
            // tb_Array_Füllen
            // 
            this.tb_Array_Füllen.Location = new System.Drawing.Point(12, 76);
            this.tb_Array_Füllen.Name = "tb_Array_Füllen";
            this.tb_Array_Füllen.Size = new System.Drawing.Size(100, 20);
            this.tb_Array_Füllen.TabIndex = 1;
            // 
            // btn_Array_Größe
            // 
            this.btn_Array_Größe.Location = new System.Drawing.Point(167, 36);
            this.btn_Array_Größe.Name = "btn_Array_Größe";
            this.btn_Array_Größe.Size = new System.Drawing.Size(128, 23);
            this.btn_Array_Größe.TabIndex = 2;
            this.btn_Array_Größe.Text = "Array Größe wählen";
            this.btn_Array_Größe.UseVisualStyleBackColor = true;
            this.btn_Array_Größe.Click += new System.EventHandler(this.btn_Array_Größe_Click);
            // 
            // btn_Eingabe
            // 
            this.btn_Eingabe.Location = new System.Drawing.Point(167, 76);
            this.btn_Eingabe.Name = "btn_Eingabe";
            this.btn_Eingabe.Size = new System.Drawing.Size(128, 23);
            this.btn_Eingabe.TabIndex = 3;
            this.btn_Eingabe.Text = "Eingabe Zahl";
            this.btn_Eingabe.UseVisualStyleBackColor = true;
            this.btn_Eingabe.Click += new System.EventHandler(this.btn_Eingabe_Click);
            // 
            // btn_Ausgabe
            // 
            this.btn_Ausgabe.Location = new System.Drawing.Point(12, 116);
            this.btn_Ausgabe.Name = "btn_Ausgabe";
            this.btn_Ausgabe.Size = new System.Drawing.Size(283, 23);
            this.btn_Ausgabe.TabIndex = 4;
            this.btn_Ausgabe.Text = "Ausgabe";
            this.btn_Ausgabe.UseVisualStyleBackColor = true;
            this.btn_Ausgabe.Click += new System.EventHandler(this.btn_Ausgabe_Click);
            // 
            // lbl_Ausgabe
            // 
            this.lbl_Ausgabe.AutoSize = true;
            this.lbl_Ausgabe.Location = new System.Drawing.Point(12, 162);
            this.lbl_Ausgabe.Name = "lbl_Ausgabe";
            this.lbl_Ausgabe.Size = new System.Drawing.Size(0, 13);
            this.lbl_Ausgabe.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 199);
            this.Controls.Add(this.lbl_Ausgabe);
            this.Controls.Add(this.btn_Ausgabe);
            this.Controls.Add(this.btn_Eingabe);
            this.Controls.Add(this.btn_Array_Größe);
            this.Controls.Add(this.tb_Array_Füllen);
            this.Controls.Add(this.tb_Array_Größe);
            this.Name = "Form1";
            this.Text = "Aufgabe_20210310";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Array_Größe;
        private System.Windows.Forms.TextBox tb_Array_Füllen;
        private System.Windows.Forms.Button btn_Array_Größe;
        private System.Windows.Forms.Button btn_Eingabe;
        private System.Windows.Forms.Button btn_Ausgabe;
        private System.Windows.Forms.Label lbl_Ausgabe;
    }
}

