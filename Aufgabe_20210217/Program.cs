using System;
/* 
 * ************************************************
 * Programm: Aufgabe_20210217
 * ************************************************
 * Author: Gabriel Schultheisz
 * Date: 22.02.2021
 * 
 * ************************************************
 * Funktion: Formatierte Ausgabe der bekanntesten Datentypen und ihr Wertebereich
 * ************************************************
 * Weitere Quellen: 
 * https://github.com/SidMcClane/ErsteApp           - Bisheriger Aufgaben (Herr Faust)
 * https://github.com/SidMcClane/Schulaufgaben      - Aufgaben ab 2021 (Herr Fecht)
 * ************************************************
 */



namespace Aufgabe_20210217 {
    class Program {
        static void Main(string[] args) {

            Welcome();

            Console.WriteLine("" +
                "\t*******************************************************************************\n" +
                "\t** Datentyp\tWertebereich\t\t\t\tKommentar \n" +
                "\t** ----------------------------------------------------------------------------\n" +
                "\t** bool\t\ttrue oder false (1 oder 0)\n" +
                "\t** int\t\t-2.147.483.648 - 2.147.483.647\t\tNur Ganzzahlen zulässig\n" +
                "\t** float\t-3.402823 E38 bis 3.402823 E38\t\tBsp. 3.8\n" +
                "\t** char\t\t0x0 - 0xFFFF\t\t\t\teinzelnes Unicode Zeichen innerhalb (')\n" +
                "\t** string\t~1.000.000.000 characters\t\tBegrenzung liegt bei ca 2GB\n" +
                "\t** ----------------------------------------------------------------------------\n" +
                "\t**\n" +
                "\t*******************************************************************************\n\n");
            Console.Write("\tDrück den Any-Key zum forfahen");
            Console.ReadKey();

        }
        public static void Welcome() {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\n\n" +
                "       █     █░▓█████  ██▓     ▄████▄   ▒█████   ███▄ ▄███▓▓█████                                     \n" +
                "      ▓█░ █ ░█░▓█   ▀ ▓██▒    ▒██▀ ▀█  ▒██▒  ██▒▓██▒▀█▀ ██▒▓█   ▀                                     \n" +
                "      ▒█░ █ ░█ ▒███   ▒██░    ▒▓█    ▄ ▒██░  ██▒▓██    ▓██░▒███                                       \n" +
                "      ░█░ █ ░█ ▒▓█  ▄ ▒██░    ▒▓▓▄ ▄██▒▒██   ██░▒██    ▒██ ▒▓█  ▄                                     \n" +
                "      ░░██▒██▓ ░▒████▒░██████▒▒ ▓███▀ ░░ ████▓▒░▒██▒   ░██▒░▒████▒                                    \n" +
                "      ░ ▓░▒ ▒  ░░ ▒░ ░░ ▒░▓  ░░ ░▒ ▒  ░░ ▒░▒░▒░ ░ ▒░   ░  ░░░ ▒░ ░                                    \n" +
                "        ▒ ░ ░   ░ ░  ░░ ░ ▒  ░  ░  ▒     ░ ▒ ▒░ ░  ░      ░ ░ ░  ░                                    \n" +
                "        ░   ░     ░     ░ ░   ░        ░ ░ ░ ▒  ░      ░      ░                                       \n" +
                "          ░       ░  ░    ░  ░░ ░          ░ ░         ░      ░  ░                                    \n" +
                "                              ░                                                                       \n");
            // Quelle : https://patorjk.com/software/taag/#p=display&h=0&w=%20&f=Bloody&t=welcome

            Console.ForegroundColor = ConsoleColor.DarkGreen;
        }
    }
}
