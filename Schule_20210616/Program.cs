using System;



namespace Schule_20210616 {

    // Zwei Klassen mit Unterklasse die erben und Objekt erstellen

    class Program {

        public struct structMeineStruktur {
            public string Title;
            public string Autor;
            public int ISBN;
            public double Preis;
        }

        


        static void Main(string[] args) {

            structMeineStruktur scParryHotter;

            scParryHotter.Title = "Fluch blabla";
            scParryHotter.Autor = "Depp";
            scParryHotter.ISBN = 35797609;
            scParryHotter.Preis = 34.99;


            Console.WriteLine(scParryHotter.Title);



            CFahrzeug OpelCorsa;
            OpelCorsa = new CFahrzeug("Opel", "Corsa", 2006, "rot", 5, 86, 1500.44);
            OpelCorsa.getAllData();

            CFahrzeug OpelVectra = new CFahrzeug("Opel", "Vectra B", 1997, "blau", 5, 116, 600.00);
            OpelVectra.getAllData();

            
            






            Console.ReadKey();
        }
    }
}
