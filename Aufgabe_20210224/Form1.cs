/* 
 * ************************************************
 * Programm: Aufgabe_20210217
 * ************************************************
 * Operation Wolkenbruch
 * 
 * Authoren: Julian Kaltenschnee, Andreas Kling, Gabriel Schultheisz, Philipp Schmiedel, Mohamad Saeed Almasri
 * 
 * Datum: 01.03.2021
 * 
 * ************************************************
 * Funktion: 2 Zahlen vergleichen - 3 Zahlen sortieren - Gaußsche Addition ;)
 * ************************************************
 * Weitere Quellen: 
 * https://github.com/SidMcClane/ErsteApp           - Bisheriger Aufgabenspaghetti (Herr Faust)
 * https://github.com/SidMcClane/Schulaufgaben      - Aufgaben ab 2021 (Herr Fecht)
 * ************************************************
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aufgabe_20210224 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        // Ausgabe der größeren Zahl
        private void btnGroesser_Click(object sender, EventArgs e) {
            int tbInt1 = Int32.Parse(tb1.Text);
            int tbInt2 = Int32.Parse(tb2.Text);

            if (tbInt1 > tbInt2) {
                lblOutA.Text = tb1.Text;
            } else {
                lblOutA.Text = tb2.Text;
            }
        }


        //  Sortierfunktion: 3 Zahlen nach aufsteigender Reihenfolge sortieren
        private void btnSort_Click(object sender, EventArgs e) {
            int tbInt1 = Int32.Parse(tb1.Text);
            int tbInt2 = Int32.Parse(tb2.Text);
            int tbInt3 = Int32.Parse(tb3.Text);
            string switchCase;
            // abc acb bac bca cab cba 

            if (tbInt1 < tbInt2 && tbInt2 < tbInt3) {
                switchCase = "abc";
                lblOutB.Text = tb1.Text + " " + tb2.Text + " " + tb3.Text;
            } else if (tbInt1 < tbInt3 && tbInt3 < tbInt2) {
                switchCase = "acb";
                lblOutB.Text = tb1.Text + " " + tb3.Text + " " + tb2.Text;
            } else if (tbInt2 < tbInt1 && tbInt1 < tbInt3) {
                switchCase = "bac";
                lblOutB.Text = tb2.Text + " " + tb1.Text + " " + tb3.Text;
            } else if (tbInt2 < tbInt3 && tbInt3 < tbInt1) {
                switchCase = "bca";
                lblOutB.Text = tb2.Text + " " + tb3.Text + " " + tb1.Text;
            } else if (tbInt3 < tbInt1 && tbInt1 < tbInt2) {
                switchCase = "cab";
                lblOutB.Text = tb3.Text + " " + tb1.Text + " " + tb2.Text;
            } else if (tbInt3 < tbInt2 && tbInt2 < tbInt1) {
                switchCase = "cba";
                lblOutB.Text = tb3.Text + " " + tb2.Text + " " + tb1.Text;
            } else {
                lblOutB.Text = "Möööp";
            }
        }

        // Gausssche Zahlen
        // Addiert alle Zahlen von 0 - eingegebene Zahl
        private void btnGausz_Click(object sender, EventArgs e) {
            int tbInt1 = Int32.Parse(tb1.Text);
            int ergebnis = 0;
            int merker = 0;

            for (int i = 0; i <= tbInt1; i++) {
                ergebnis = i + merker;
                merker = ergebnis;
            }
            lblOutC.Text = ergebnis.ToString();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) {
            if (checkBox1.Checked == true) {
                tb1.Enabled = true;
                tb2.Enabled = true;
                btnGroesser.Enabled = true;
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
            }
            if (checkBox1.Checked == false) {
                disableAll();
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e) {
            if (checkBox2.Checked == true) {
                tb1.Enabled = true;
                tb2.Enabled = true;
                tb3.Enabled = true;
                btnSort.Enabled = true;
                checkBox1.Enabled = false;
                checkBox3.Enabled = false;
            }
            if (checkBox2.Checked == false) {
                disableAll();
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e) {
            if (checkBox3.Checked == true) {
                tb1.Enabled = true;
                btnGausz.Enabled = true;
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
            }
            if (checkBox3.Checked == false) {
                disableAll();
            }
        }

        // Methode um alles zurück zu setzen
        private void disableAll() {
            tb1.Enabled = false;
            tb2.Enabled = false;
            tb3.Enabled = false;
            btnGroesser.Enabled = false;
            btnSort.Enabled = false;
            btnGausz.Enabled = false;
            checkBox1.Enabled = true;
            checkBox2.Enabled = true;
            checkBox3.Enabled = true;

        }


    }
}
