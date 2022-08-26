using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class LendoDados {

        public static void Executar() {
            Console.WriteLine("What´s your name? ");
            string name = Console.ReadLine();

            Console.WriteLine("How old are you? ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("How much is yours montlhy wages?");
            double wage = double.Parse(Console.ReadLine());

            Console.WriteLine($"My name is {name} I am {age} years old and my monthly wage is {wage}");
        }
    }
}
