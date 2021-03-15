using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* 
 * ************************************************
 * Programm: Aufgabe_20210310
 * ************************************************
 * Author: Gabriel Schultheisz
 * Date: 15.03.2021
 * 
 * ************************************************
 * Funktion: Erstellt ein Array in Benutzerdffinierten Größe, nimmt entsprechend viele Zahlen an
 * und gibt sie als String in einem Lable aus
 * ************************************************
 * Weitere Quellen: 
 * https://github.com/SidMcClane/ErsteApp           - Bisheriger Aufgaben (Herr Faust)
 * https://github.com/SidMcClane/Schulaufgaben      - Aufgaben ab 2021 (Herr Fecht)
 * ************************************************
 */

namespace Aufgabe_20210310 {
    public partial class Form1 : Form {

        int[] zahlen_Array;
        int zähler = 0;

        public Form1() {
            InitializeComponent();
        }
        private void btn_Array_Größe_Click(object sender, EventArgs e) {
            zahlen_Array = new int[Int32.Parse(tb_Array_Größe.Text)];
            tb_Array_Größe.Text = "";
            btn_Array_Größe.Visible = false;
        }

        private void btn_Eingabe_Click(object sender, EventArgs e) {
            zahlen_Array[zähler] = Int32.Parse(tb_Array_Füllen.Text);

            zähler++;
            if (zähler == zahlen_Array.Length) {
                btn_Eingabe.Visible = false;
            }

            tb_Array_Füllen.Text = "";

        }

        private void btn_Ausgabe_Click(object sender, EventArgs e) {
            foreach (int i in zahlen_Array) {
                lbl_Ausgabe.Text = string.Join(",", zahlen_Array);
            }
            btn_Array_Größe.Visible = true;
            btn_Eingabe.Visible = true;
            zähler = 0;
        }
    }
}
