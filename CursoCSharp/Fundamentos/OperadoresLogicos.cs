using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class OperadoresLogicos {
        public static void Executar() {
            var workExecutaded1 = true;
            var workExecutaded2 = false;

            bool tv50 = workExecutaded1 || workExecutaded2;
            Console.WriteLine("a tv de 50pol será adquirida: ? {0}, {1}", tv50, !tv50);
        }
    }
}
