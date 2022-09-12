using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {

     public class Moto {
        private string Brand;
        private string Model;
        private int Cil;
        // private é palavra reservada do C#
        // vai encapsular, privar o acesso, visivel apenas internamente na classe

        // criando o construtor
        public Moto(string brand, string model, int cil) {
            Brand = brand;
            Model = model;
            Cil = cil;
        }

        // criando um segundo construtor
        public Moto() {
        
        }

        // usando get e set - usando PascalCase
        // Brand
        public string GetBrand() {
            return Brand;
        }
        public void SetBrand (string brand) {
            Brand = brand;
        }

        // Model
        public string GetModel() {
            return Model;
        }
        public void SetModel(string model) {
            Model = model;
        }

        // Cilindradas
       public int GetCil() {
            return Cil;
        }

        public void SetCil(int cil) {
            Cil = cil;
        }
    }
    class GettersSetters {



        public static void Executar() {
            var moto1 = new Moto("BMW", "GS650", 650);

            Console.WriteLine(moto1.GetBrand());
            Console.WriteLine(moto1.GetModel());
            Console.WriteLine(moto1.GetCil());

            var moto2 = new Moto("Harley", "fatboy", 1100);

            Console.WriteLine(moto2.GetBrand());
            Console.WriteLine(moto2.GetModel());
            Console.WriteLine(moto2.GetCil());

            var moto3 = new Moto();
            moto3.SetBrand("Honda");
            moto3.SetModel("CGzinha");
            moto3.SetCil(150);
            Console.WriteLine(moto3.GetBrand() + " é a " + moto3.GetModel() + " tem cilindradas de " + moto3.GetCil());


        }
    }
}
