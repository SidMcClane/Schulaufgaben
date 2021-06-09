using System;

namespace Schule_20210608 {
    // KLASSENDEFINITION
    class Mitarbeiter {
        private string vorname;
        private string nachname;
        private int gebDatum;
        private int maID;

        //SETer und GETer
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

        // Konstruktoren / Methoden
        public Mitarbeiter() { 
        }

        public Mitarbeiter(string vn, string nn, int gd) {
            vorname = vn;
            nachname = nn;
            gebDatum = gd;
        }

        public Mitarbeiter(string vn, string nn, int gd, int id) {
            vorname = vn;
            nachname = nn;
            gebDatum = gd;
            maID = id;
        }

        public void maDaten() {
            Console.WriteLine($"Der Mitarbeiter {vorname} {nachname} ist {gebDatum} geboren und hat die MitarbeiterID {maID}");
        }

    }

    // ******************************************
    // Hauptprogramm
    class Program {
        static void Main(string[] args) {


            // MA anlegen und abrufe mit GETer und SETer
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
            Console.WriteLine();


            // MA anlegen mit Konstruktor (light)
            Mitarbeiter Klaus;
            Klaus = new Mitarbeiter("Klaus", "Laus", 1992);

            Console.WriteLine(Klaus.getVorname());
            Console.WriteLine(Klaus.getNachname());
            Console.WriteLine(Klaus.getGebDatum());
            Console.WriteLine();

            Klaus.maDaten();
            Console.WriteLine();

            // MA anlegen mit Konstruktor (full)
            Mitarbeiter Gustav;
            Gustav = new Mitarbeiter("Gustav", "Gans", 1988, 654);

            Console.WriteLine(Gustav.getVorname());
            Console.WriteLine(Gustav.getNachname());
            Console.WriteLine(Gustav.getGebDatum());
            Console.WriteLine(Gustav.getMaID());
            Console.WriteLine();


            // MA "light" wurde eingestellt und erhält seine Personalnummer (MaID)
            Klaus.setMaID(777);

            Console.WriteLine(Klaus.getVorname());
            Console.WriteLine(Klaus.getNachname());
            Console.WriteLine(Klaus.getGebDatum());
            Console.WriteLine(Klaus.getMaID());
            Console.WriteLine();


            // Alle Daten per Methode abrufen als Text
            Gustav.maDaten();
            Klaus.maDaten();
            Hans.maDaten();
            Console.WriteLine();





            Console.Write("Voname: ");
            string inputVorname = Console.ReadLine();
            Console.Write("Nachname: ");
            string inputNachname = Console.ReadLine();
            Console.Write("Gaburtsdatum: ");
            int inputGebDatum = Convert.ToInt32(Console.ReadLine());
            Console.Write("MitarbeiterID: ");
            int inputMaID = Convert.ToInt32(Console.ReadLine());

            Mitarbeiter Gabba;
            Gabba = new Mitarbeiter(inputVorname, inputNachname, inputGebDatum, inputMaID);
            Gabba.maDaten();
            

            Console.ReadKey();


        }
    }
}
