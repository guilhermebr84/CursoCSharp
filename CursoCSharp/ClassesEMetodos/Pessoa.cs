using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    class Pessoa {
        // public permite que o atributo esteja visivel
        // a convenção usa Pascal Case para nome de atributos
        public string Name;
        public int Age;

        // criando um metodo de apresentar, nesse caso não será passado parametros.
        // o "return" é necessário, retorna uma string.
        public string Apresentar() {
            return string.Format($"Olá! Me chamo {Name} e tenho {Age} anos de idade.");
        }

        // mostrar um exemplo de metodo que nao retorno nada.
        public void ApresentarNoConsole() {
            // chamando o método Apresentar () para não precisar repetir codigo
            Console.WriteLine(Apresentar());
        }

        public void Zerar() {
            Name = " ";
            Age = 0;
        }


    }
}
