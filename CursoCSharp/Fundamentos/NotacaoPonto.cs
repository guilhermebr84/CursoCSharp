using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class NotacaoPonto {
        public static void Executar () {
            var salutation = "hello".ToUpper().Insert(5, " World!").
                Replace(" World!", " Brazil!");
            Console.WriteLine(salutation);

            //string importantValue = "empty";

        }
    }
}
