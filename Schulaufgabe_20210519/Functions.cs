using System;
using System.Collections.Generic;
using System.Text;

namespace Schulaufgabe_20210519 {
    class Functions {

        /// <summary>
        /// Summiert alle Zahlen von der ersten Zahl bis zur letzten Zahl
        /// </summary>
        /// <param name="zahl_von">Die kleinere Zahl</param>
        /// <param name="zahl_bis">Die größere Zahl</param>
        /// <returns>int</returns>
        public static int SummeFunc(int zahl_von, int zahl_bis) {
            int ergeb = zahl_von;

            while (zahl_von < zahl_bis) {
                ergeb += zahl_bis;        // ergeb = ergeb + zahl_bis
                zahl_bis--;
            }
            return ergeb;
        }

        /// <summary>
        /// Multipliziert alle Zahlen von der ersten bis zur letzten Zahl
        /// </summary>
        /// <param name="zahl_von">Die kleinere Zahl</param>
        /// <param name="zahl_bis">Die größere Zahl</param>
        /// <returns>int</returns>
        public static int Fakfunc(int zahl_von, int zahl_bis) {
            int ergeb = zahl_von;

            while (zahl_von < zahl_bis) {
                ergeb *= zahl_bis;        // ergeb = ergeb * zahl_bis
                zahl_bis--;
            }
            return ergeb;
        }





    }
}
