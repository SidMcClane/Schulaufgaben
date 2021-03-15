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
 * Programm: Aufgabe_20210303
 * ************************************************
 * Author: Gabriel Schultheisz
 * Date: 15.03.2021
 * 
 * ************************************************
 * Funktion: Übernimmt aus 5 Textboxen 5 Zahlen, speichert sie in einem Array
 * und gibt sie als String in einem Lable aus
 * ************************************************
 * Weitere Quellen: 
 * https://github.com/SidMcClane/ErsteApp           - Bisheriger Aufgaben (Herr Faust)
 * https://github.com/SidMcClane/Schulaufgaben      - Aufgaben ab 2021 (Herr Fecht)
 * ************************************************
 */

namespace Aufgabe_20210303 {
    public partial class Aufgabe_20210303 : Form {
        public Aufgabe_20210303() {
            InitializeComponent();
        }

        private void btn_Ausgabe_Click(object sender, EventArgs e) {
            int[] zahlen_Liste = new int[5];

            int zahl_1 = Int32.Parse(tb_Zahl_1.Text);
            int zahl_2 = Int32.Parse(tb_Zahl_2.Text);
            int zahl_3 = Int32.Parse(tb_Zahl_3.Text);
            int zahl_4 = Int32.Parse(tb_Zahl_4.Text);
            int zahl_5 = Int32.Parse(tb_Zahl_5.Text);

            zahlen_Liste[0] = zahl_1;
            zahlen_Liste[1] = zahl_2;
            zahlen_Liste[2] = zahl_3;
            zahlen_Liste[3] = zahl_4;
            zahlen_Liste[4] = zahl_5;

            foreach (int i in zahlen_Liste) {
                lbl_Ausgabe.Text = string.Join(",", zahlen_Liste);
            }

        }
    }
}
