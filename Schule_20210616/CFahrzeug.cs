using System;
using System.Collections.Generic;
using System.Text;

namespace Schule_20210616 {
    class CFahrzeug {

        // Attribute
        private string attHersteller;
        private string attModel;
        private int attBaujahr;
        private string attFarbe;
        private int attSitzplaetze;
        private int attLeistung;
        private double attPreis;

        // Methoden (getter und setter)
        public string getHersteller() {
            return attHersteller;
        }
        public string getModel() {
            return attModel;
        }
        public int getBaujahr() {
            return attBaujahr;
        }
        public string getFarbe() {
            return attFarbe;
        }
        public int getSitzplaetze() {
            return attSitzplaetze;
        }
        public int getLeistung() {
            return attLeistung;
        }
        public double getPreis() {
            return attPreis;
        }
        public void getAllData() {
            Console.WriteLine($"" +
                $"Hersteller/Model: \t{attHersteller} {attModel}\n" +
                $"Baujahr: \t\t{attBaujahr}\n" +
                $"Farbe: \t\t\t{attFarbe}\n" +
                $"Sitzplätze: \t\t{attSitzplaetze}\n" +
                $"Leistung: \t\t{attLeistung} PS\n" +
                $"Preis: \t\t\t{attPreis} Euro\n\n");
        }



        // Konstruktoren
        public CFahrzeug() { 
        }

        public CFahrzeug(
                        string Hersteller,
                        string Model,
                        int Baujahr,
                        string Farbe,
                        int Sitzplaetze,
                        int Leistung,
                        double Preis) {
            attHersteller = Hersteller;
            attModel = Model;
            attBaujahr = Baujahr;
            attFarbe = Farbe;
            attSitzplaetze = Sitzplaetze;
            attLeistung = Leistung;
            attPreis = Preis;
        }
    }
}
