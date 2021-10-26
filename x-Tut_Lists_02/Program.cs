using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace x_Tut_Lists_02 {
    class Program {
        static void Main(string[] args) {

            var fibonacciNumbers = new List<int> { 1, 1 };

            var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
            var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

            fibonacciNumbers.Add(previous + previous2);

            foreach (var item in fibonacciNumbers)
                Console.WriteLine(item);

            Console.WriteLine();

            var fiboNumbers = new List<int> { 1, 1 };

            for (int i = 3; i <= 20; i++) {

            var ersteZahl = fiboNumbers[fiboNumbers.Count - 1];
            var zweiteZahl = fiboNumbers[fiboNumbers.Count - 2];

                fiboNumbers.Add(ersteZahl + zweiteZahl);
            }

            Console.WriteLine(fiboNumbers[fiboNumbers.Count -1]);




            Console.ReadKey();
        }
    }
}
