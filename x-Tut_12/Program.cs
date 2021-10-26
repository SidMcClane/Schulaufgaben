using System;
using System.Collections.Generic;

namespace x_Tut_Lists_01 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine();
            
            var names = new List<string> { "Gabe", "Ana", "Felipe" };

            names.Add("Gabba");
            names.Add("Karina");
            names.Add("Selly");
            names.Add("Sara");
            names.Add("Lena");

            names.Remove("Gabe");
            names.Remove("Ana");
            names.Remove("Felipe");

            names.Sort();
            foreach (var name in names) {

                Console.WriteLine($"Hallo {name}");
            }

            Console.WriteLine();
            bool repeat = true;
            while (repeat) {

                Console.WriteLine("Gesuchten Namen eingeben");
                string eingabe = Console.ReadLine();

                Console.WriteLine();
                var indey = names.IndexOf(eingabe);

                if (indey == -1) {
                    Console.WriteLine($"{eingabe} ist nicht in der Liste");
                } else {
                    Console.WriteLine($"{names[indey]} hat Index-Nr. {indey}");
                }

                Console.Write("Zum beenden der Abfrage 'no' eingeben: ");
                if (Console.ReadLine() == "no") {
                    repeat = false;
                }
            }

            Console.ReadKey();
        }
    }
}
