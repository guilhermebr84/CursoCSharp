using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    class ParamsNomeados {

        
        public static void Formatar (int dia, int mes, int ano) {
            // na hora de chamar essa função que recebe 3 inteiros, pode haver confusao
            // estrategia de formatação:
            Console.WriteLine(  "{0:D2}/{1:D2}/{2}", dia, mes, ano);

            // :D2 - colocar zeros à esquerda para deixar com 2 digitos
        }

        public static void Executar () {
            Formatar(mes: 7, dia: 4, ano: 1997);

            // parametros nomeados traz um codigo mais compreensivel

        }
    }
}
