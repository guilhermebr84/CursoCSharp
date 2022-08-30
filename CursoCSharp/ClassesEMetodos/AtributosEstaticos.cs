using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {

    public class Product {
        public string Name;
        public double Price;
        public double Discount = 0.1;

        public Product(string name, double price, double discount) {
            Name = name;
            Price = price;
            Discount = discount;
        }
        
        //construtor
        public Product () {

        }

        public double DiscountCalculator() {
            return Price - (Price * 0.1);
        }
    }
    class AtributosEstaticos {

        public static void Executar () {
            
        }
    }
}
