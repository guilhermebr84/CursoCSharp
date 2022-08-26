using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class OperadoresAtribuicao {
        public static void Executar() {
            var num1 = 3;
            num1 = 7;
            num1 += 13;
            num1 *= 5;
            num1 /= 2;
            num1 -= 5;
            num1 *= 6;
            num1 += 48;
            Console.WriteLine(num1);

            int a = 50;
            int b = a - 15;

            Console.WriteLine(b);
        }
    }
}
