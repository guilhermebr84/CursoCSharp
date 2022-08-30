using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    class Car {
        public string Model;
        public string Factory;
        public int Year;

        //nesse caso podemos inserir parametros
        public Car(string model, string factory, int year) {
            Model = model;
            Factory = factory;
            Year = year;
        }

        public Car() {

        }

    }

    class Construtores {
        public static void Executar() {
            // construtor padrão não recebe parametros
            var car1 = new Car();
            car1.Model = "Celta";
            car1.Factory = "GMC";
            car1.Year = 2008;

            Console.WriteLine($"I have a {car1.Factory} model {car1.Model} built in {car1.Year}");

            var car2 = new Car("Maverick", "Ford", 1995);
            Console.WriteLine($"My second car is a {car2.Factory} {car2.Model} year {car2.Year}");

            var car3 = new Car() {
                Model = "355 Spider",
                Factory = "Ferrari",
                Year = 1999
            };
            Console.WriteLine($"I also have a {car3.Factory} {car3.Model} year {car3.Year}");
        }
    }
}
