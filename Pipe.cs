using System;
using System.Collections.Generic;

namespace cs_multifabriken1 {

    class Pipe : ProductTypev1 {

        // attributes
        public string diameter;
        public string length;

        public Pipe(){
            // type inherited from productType
            this.type = "Pipe";
        }

        // methods:
        public void AddDiameter() {
            System.Console.WriteLine("Type Diameter number:");
            string input = Console.ReadLine();
            this.diameter = input;
        }

        public void AddLength() {
            System.Console.WriteLine("Type length:");
            string input = Console.ReadLine();
            this.length = input;
        }

        // public void AddToList(Pipe pip) {
        //     pipeList.Add(pip);
        // }

        // public void PrintList(){
        //     foreach (var pipe in pipeList)
        //     {   
        //         Console.WriteLine("Produkt:{0}", pipe.type);
        //         Console.WriteLine("Diameter:{0}", pipe.diameter);
        //         Console.WriteLine("Length:{0}", pipe.length);
        //     }
        // }
    }

}