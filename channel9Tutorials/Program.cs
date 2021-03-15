using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace channel9Tutorials {
    class Program {
        static void Main(string[] args) {

            int a = 5;
            int b = 3;
            if (a + b > 10) {
                Console.WriteLine("The answer is greater than 10.");
            }

            int x = int.MaxValue;
            int y = int.MinValue;
            Console.WriteLine($"Int minimum ist {y} und geht bis {x}");

            Console.ReadKey();


        }
    }
}
