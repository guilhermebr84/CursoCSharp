using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    class DesafioAtributo {

        int a = 10;
        // um metodo que pertence a classe nao consegue acessar um atributo de instancia
        public static void Executar() {
            //acesse o valor "a"
            //Console.WriteLine(a);

            // para acessar a variável "a" é preciso criar uma instancia da classe DesafioAtributo
            DesafioAtributo desafio = new DesafioAtributo();
            Console.WriteLine(desafio.a);
        }

    }
}
