using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class Conversoes {
        public static void Executar () {
            int integer = 10;
            double broke = integer;
            Console.WriteLine(broke);

            double grade = 9.7;
            int brokeGrade = (int)grade;
            Console.WriteLine("Broke Grade: {0}", brokeGrade);

            Console.WriteLine("How old are You? Type here: ");
            string ageStr = Console.ReadLine();
            int ageInt = int.Parse(ageStr);
            Console.WriteLine("Age inserted: {0}", ageInt);

            ageInt = Convert.ToInt32(ageStr);
            Console.WriteLine("Result: {0}", ageInt);

            Console.WriteLine("Digit a number:");

        }
    }
}
