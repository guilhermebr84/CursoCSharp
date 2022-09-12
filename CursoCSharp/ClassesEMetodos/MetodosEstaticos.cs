using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {

public class StaticCalc {
        // quando usa o metodo "static" significa que o metodo refere-se ao metodo
        public int Sum(int a, int b) { // metodo de instancia
            return a + b;
        }

        public static int Multiplication(int a, int b) { // metodod de classe ou estático
            return a * b;
        }
    }
    class MetodosEstaticos {
        public static void Executar() { 
            var result = StaticCalc.Multiplication(5, 6);
            Console.WriteLine("result = {0}", result);

            StaticCalc calc = new StaticCalc();

            // na classe nao pode definir como estatico no caso do metodo Sum
            Console.WriteLine(calc.Sum(3, 6));
            Console.WriteLine(StaticCalc.Multiplication(8, 32));
        }
    }
}
