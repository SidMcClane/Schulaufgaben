using System;
/* 
 * ************************************************
 * Programm: Schulaufgabe_20210519
 * ************************************************
 * Author: Gabriel Schultheisz
 * Date: 19.05.2021
 * 
 * ************************************************
 * Funktion: Ausgabe der Summe bzw Fakultät von Zahl 1 bis Zahl 2
 * ************************************************
 * Weitere Quellen: 
 * https://github.com/SidMcClane/ErsteApp           - Bisheriger Aufgaben (Herr Faust)
 * https://github.com/SidMcClane/Schulaufgaben      - Aufgaben ab 2021 (Herr Fecht)
 * ************************************************
 */

namespace Schulaufgabe_20210519 {
    class Program {
        static void Main(string[] args) {

            int zahl_1 = 2;
            int zahl_2 = 8;
            int summe = Functions.SummeFunc(zahl_1, zahl_2);
            int fakultaet = Functions.Fakfunc(zahl_1, zahl_2);

            Console.WriteLine($"Die Summe \tvon {zahl_1} bis {zahl_2} ist gleich: {summe}");
            //Console.WriteLine(Convert.ToString(Functions.SummeFunc(zahl_1, zahl_2)));

            Console.WriteLine($"Die Fakultät \tvon {zahl_1} bis {zahl_2} ist gleich: {fakultaet}");
            //Console.WriteLine(Convert.ToString(Functions.Fakfunc(zahl_1, zahl_2)));
        }
    }
}
