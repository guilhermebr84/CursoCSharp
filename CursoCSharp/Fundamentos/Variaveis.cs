using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class Variaveis {
        public static void Executar () {
            //area de curcuferencia
            //double é o tipo da variável. double é uma palavra reservada do c#
            //double pode ser alterado.
            double radius = 4.5;
            const double PI = 3.14;

            radius = 5.5;

            double area = PI * radius * radius;
            Console.WriteLine(area); 
            // concatenação
            Console.WriteLine("A área é de:" + area);

            // tipos interno

            bool isRaining = true;
            Console.WriteLine("Is Raining " + isRaining);

            byte age = 45;
            Console.WriteLine("Age " + age);

            sbyte goalsScored = sbyte.MinValue;
            Console.WriteLine("Goals Scored: " + goalsScored);

            short salary = short.MaxValue;
            Console.WriteLine("The salary is: " + salary);

            int lowestValueInt = int.MinValue;
            Console.WriteLine("The Lowest Value is: " + lowestValueInt);

            uint popBrazil = 207_600_000;
            Console.WriteLine("the brazilian population is: " + popBrazil);

            long lowestValueLong = long.MinValue;
            Console.WriteLine("the lowest value for long is: " + lowestValueLong);

            ulong popWorld = 7_600_000_000;
            Console.WriteLine("the world population is: " + popWorld);

            // tem que usar o "f", por padrao, para definir como float
            float priceComp = 1385.97f;
            Console.WriteLine("the computer price is: " + priceComp);

            double appleMarketValue = 1_000_000_000_000.00;
            Console.WriteLine("the value market of Apple is: " + appleMarketValue);

            decimal distanceBetweenStars = decimal.MaxValue;
            Console.WriteLine("the distance between the main stars in the sky is: " + distanceBetweenStars);

            //usar aspas simples para guardar UMA letra
            char letter = 'g';
            Console.WriteLine("my letter is: " + letter);

            string texto = "any string";
            Console.WriteLine("the string name is: " + texto);



        }
    }
}
