using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos {
    class Formatando_Numeros {

        public static void Executar () {
            double value = 15.175;
            Console.WriteLine(value.ToString("F1"));
            Console.WriteLine(value.ToString("C"));
            Console.WriteLine((value/100).ToString("P"));
            Console.WriteLine(value.ToString("#.##"));

            //informação de cultura local, conforme as configurações do windows
            CultureInfo culture = new CultureInfo("pt-BR");
            Console.WriteLine(value.ToString("C0", culture));

            int intenger = 187569243;
            Console.WriteLine(intenger.ToString("D12"));
        }


    }
}
