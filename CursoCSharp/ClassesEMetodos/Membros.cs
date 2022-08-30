using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    class Membros {
         public static void Executar () {
            Pessoa individuo1 = new Pessoa();

            //notação "ponto" forma de acessar membros da classe
            individuo1.Name = "Renato";
            individuo1.Age = 21;

            // Console.WriteLine($"{individuo.Name} tem {individuo.Age} anos de idade");

            individuo1.ApresentarNoConsole();

            var individuo2 = new Pessoa();
            individuo2.Name = "Beto Salada";
            individuo2.Age = 35;

            var apresentacaoInd2 = individuo2.Apresentar();
            Console.WriteLine(apresentacaoInd2.Length);
            

        }
    }
}
