using System;

namespace Schule_20210602 {

    // KLASSENDEFINITION
    class Mitarbeiter {
        private string vorname;
        private string nachname;
        private int gebDatum;
        private int maID;

        public void setVorname(string setVorname) {
            vorname = setVorname;
        }
        public void setNachname(string setNachname) {
            nachname = setNachname;
        }
        public void setGebDatum(int setGebDatum) {
            gebDatum = setGebDatum;
        }
        public void setMaID(int setMaID) {
            maID = setMaID;
        }

        public string getVorname() {
            return vorname;
        }
        public string getNachname() {
            return nachname;
        }
        public int getGebDatum() {
            return gebDatum;
        }
        public int getMaID() {
            return maID;
        }
    }

    // ******************************************
    // Hauptprogramm
    class Program {
        static void Main(string[] args) {

            Mitarbeiter Hans;

            Hans = new Mitarbeiter();

            Hans.setVorname("Hans");
            Hans.setNachname("Wurst");
            Hans.setGebDatum(1990);
            Hans.setMaID(66);

            Console.WriteLine(Hans.getVorname());
            Console.WriteLine(Hans.getNachname());
            Console.WriteLine(Hans.getGebDatum());
            Console.WriteLine(Hans.getMaID());

            Console.ReadKey();
        }
    }
}
