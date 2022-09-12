using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    class Params {

        //criando um outro metodo estatico

        public static void Recepcionar (params string[] pessoas) {
            // params é um termo-palavra reservado/a no C#
            // uso o foreach para percorrer um grupo de nomes

            foreach (var pessoa in pessoas) {
                // pessoas é o nome do parametro
                Console.WriteLine("Olá {0}", pessoa);
            }
        }
        public static void Executar () {
            // passo os parametros separados por virgula
            Recepcionar("Oliveira", "Manuel", "Cecilia", "Matheus", "Guilherme", "Dani");

            // com a palavra reservada params - parametros para um metodo - vc passa os valores
        }
    }
}
