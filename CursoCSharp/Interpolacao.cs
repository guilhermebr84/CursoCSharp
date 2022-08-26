using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp {
    class Interpolacao {
        public static void Executar(){

            string nameComp = "Notebook 102030";
            string brand = "Dell";
            double price = 5999.99;

            Console.WriteLine("O " + nameComp + " da marca " + brand + "custa " + price);

            Console.WriteLine("Também podemos dizer que o {0} da marca {1} custa {2}, alguns acham caro", nameComp, brand, price);
            Console.WriteLine($"Podemos utilizar o computador {brand}. Um modelo em especial é o {nameComp} que hoje custa {price}");
            Console.WriteLine($"se somar 5 com 6 temos {5 + 6}" );
        }
    }
}
