using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class OperadoresTernarios {

        public static void Executar () {
            
            var grade = 8.0;

            Console.WriteLine("Set the student grade: " + grade);

            string result = grade >= 7.0 ? "approved" : "reproved";

            Console.WriteLine(result);

        }
    }
}
