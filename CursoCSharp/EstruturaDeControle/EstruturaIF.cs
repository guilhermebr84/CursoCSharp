using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle {
    class EstruturaIF {

        public static void Executar () {
            bool niceComportment = false;
            string entry;

            Console.WriteLine("Enter student grade: ");
            entry = Console.ReadLine();
            Double.TryParse(entry, out double grade);

            Console.WriteLine("The student has a nice comportament (Y/N): ");
            entry = Console.ReadLine().ToLower();

            if (entry == "y" && grade >= 7.0) {
                niceComportment = true;
                Console.WriteLine("the student is approved");
            }

        }
    }
}
