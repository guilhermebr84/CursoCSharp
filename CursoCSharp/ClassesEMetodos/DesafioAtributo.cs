using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    class DesafioAtributo {

        int a = 10;
        public static void Executar() {
            // para acessar a variável "a" é preciso criar uma instancia da classe DesafioAtributo
            DesafioAtributo desafio = new DesafioAtributo();
            // acessando a classe dentro de um metodo estatico
            Console.WriteLine(desafio.a);
            // acessando por notação ponto
        }

    }
}
