using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class OperadoresAritmeticos {

        public static void Executar () {
            var price = 1000.00;
            var tax = 160.00;
            var discount = 0.1;

            // um preço com desconto
            double total = price + tax;
            double totalDisc = total - (total * discount);
            Console.WriteLine("Preço final com imposto e desconto: {0}", totalDisc);

            //calculando IMC
            double weightKG = 120;
            double heightM = 1.78;
            double imc = weightKG / Math.Pow(heightM, 2);
            Console.WriteLine("IMC: {0}", imc);

            //numero par/impar usando modulo
            int par = 42;
            int impar = 55;
            Console.WriteLine("When you divide {0} by 2, you got rest {1}", par, par%2);
            Console.WriteLine("When you divide {0} by 2, you got rest {1}", impar, impar % 2);
        }
    }
}
