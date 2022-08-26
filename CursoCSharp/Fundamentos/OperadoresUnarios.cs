using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class OperadoresUnarios {

        public static void Executar () {
            var num1 = -8;
            var num2 = 7;
            var num3 = 11;
            var num4 = 12;
            var booleano = true;

            Console.WriteLine(num1 - 5);

            Console.WriteLine(num2);
            num2++;
            Console.WriteLine(num2);

            Console.WriteLine(num3);
            --num3;
            Console.WriteLine(num3);

            Console.WriteLine(booleano);

            Console.WriteLine(!booleano);

            //podemos incrementar os numeros antes ou depois de uma comparação 
            //antes: inserir o ++ ou -- antes - depois: inserir o ++ ou -- depois.
            Console.WriteLine(++num2 == --num3);

            Console.WriteLine($"{num2} e {num3}");

        }
    }
}
