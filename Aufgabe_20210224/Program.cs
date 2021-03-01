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
 * Funktion: 2 Zahlen vergleichen - 3 Zahlen sortieren - Gauﬂsche Addition ;)
 * ************************************************
 * Weitere Quellen: 
 * https://github.com/SidMcClane/ErsteApp           - Bisheriger Aufgabenspaghetti (Herr Faust)
 * https://github.com/SidMcClane/Schulaufgaben      - Aufgaben ab 2021 (Herr Fecht)
 * ************************************************
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aufgabe_20210224 {
    static class Program {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
