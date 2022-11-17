using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
	
	public class CarroOpcional {
		double desconto = 0.1;

		string nome;
		public string Nome {
			get {
				return "Opcional: " + nome;
            }
			set {
				nome = value;
            }
        }

		public double Preco { get; set; }

		public double PrecoComDesconto {
			get => Preco - (desconto * Preco); //Lambda
        }

		public CarroOpcional() {

        }

		public CarroOpcional( string nome, double preco) {
			Nome = nome;
			Preco = preco;


        }
    }

	class Props {
		public static void Executar() {

			var op1 = new CarroOpcional("Ar-Cond", 3499.9);

			Console.WriteLine(op1.PrecoComDesconto);
			
		}
	}
}
