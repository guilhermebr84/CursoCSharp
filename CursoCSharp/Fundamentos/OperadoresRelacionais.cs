using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class OperadoresRelacionais {

        public static void Executar () {
            Console.Write("Digite a nota: ");
            double.TryParse(Console.ReadLine(), out double grade);
            double cutGrade = 7.0;

            Console.WriteLine("nota invalida? {0}", grade > 10.0);
            Console.WriteLine("nota invalida? {0}", grade < 0.0);
            Console.WriteLine("Perfeito? {0}", grade == 10.00);
            Console.WriteLine("Pode melhorar? {0}", grade != 10.00);
            Console.WriteLine("Passou por media: {0}", grade >= cutGrade);
            Console.WriteLine("Recuperação: {0}", grade < cutGrade);
            Console.WriteLine("Reprovado: {0}", grade <= 3.0);

        }
    }
}
