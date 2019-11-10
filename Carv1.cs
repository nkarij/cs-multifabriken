using System;
using System.Collections.Generic;
using System.Reflection;

namespace cs_multifabriken1 {

    class Carv1 : ProductTypev1 {

        // attributes
        public string licenseNumber;
        public string model;
        public string color;

        // public List<object> carList = new List<object>();

        public Carv1(){
            // type inherited from productType
            this.type = "Car";
        }

        // methods:
        public void AddLicense(string license) {
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

    }

}