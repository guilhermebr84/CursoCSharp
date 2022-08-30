using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {

    //classe
    class Calc1 { //calculadora comum
        //metodo
        public int Sum(int a, int b) {
            return a + b;
        }

        public int Substraction(int a, int b) {
            return a - b;
        }
        
        public int Multiplication (int a, int b) {
            return a * b;
        }

        public int Division (int a, int b) {
            return a / b;
        }

        }

    class Calc2 { // caculadora cadeia
        int memory;

        public Calc2 Sum (int a) {
            memory += a;
            return this;
        }

        public Calc2 Multiplication (int a) {
            memory *= a;
            return this;
        }

        public Calc2 Substraction(int a) {
            memory -= a;
            return this;
        }

        public Calc2 Division(int a) {
            memory /= a;
            return this;
        }

        public Calc2 CleanScreen() {
            memory = 0;
            return this;
        }

        public Calc2 Print() {
            Console.WriteLine(memory);
            return this;
        }

        public int Result() {
            return memory;
        }
    }

    class MetodosComRetorno {
        public static void Executar () {
            //instaciando as classes
            var calculadoraComum = new Calc1();

            Console.WriteLine($"A somatória de 5+9 é {calculadoraComum.Sum(5, 9)}");
            Console.WriteLine($"A subtração de 45-8 é {calculadoraComum.Substraction(45, 8)}");
            Console.WriteLine($"A multiplicação de 15+74 é {calculadoraComum.Multiplication(15, 74)}");
            Console.WriteLine($"A divisão entre de 105 por 5 é {calculadoraComum.Division(105, 5)}");

            var calculadoraCadeia = new Calc2();
            calculadoraCadeia.Sum(7).Multiplication(2).Print().CleanScreen().Print();
        }
    }
}
