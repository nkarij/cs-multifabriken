using System;
using System.Collections.Generic;
using System.Reflection;

namespace cs_multifabriken1 {

    class Carv1 : ProductTypev1 {

        // attributes
        public string licenseNumber;
        public string model;
        public string color;

        public Carv1(){
            // type inherited from productType
            this.type = "Car";
        }

        // methods:
        public void AddLicense() {
            System.Console.WriteLine("Type License number:");
            string license = Console.ReadLine();
            this.licenseNumber = license;
        }

        public void AddColor() {
            System.Console.WriteLine("Type color:");
            string color = Console.ReadLine();
            this.color = color;
        }

        public void AddModel() {
            System.Console.WriteLine("Type model:");
            string model = Console.ReadLine();
            this.model = model;
        }

        // public void AddToList(Carv1 car) {
        //     carList.Add(car);
        // }

        // public void PrintList(){
        //     foreach (var car in carList)
        //     {   
        //         Console.WriteLine("Produkt:{0}", car.type);
        //         Console.WriteLine("License:{0}", car.licenseNumber);
        //         Console.WriteLine("Model:{0}", car.model);
        //         Console.WriteLine("Color:{0}", car.color);
        //     }
        // }
    }

}