using System;
using System.Collections.Generic;

namespace cs_multifabriken1 {

    class Candy : ProductTypev1 {

        // attributes
        public string taste;
        public string count;

        public Candy(){
            // type inherited from productType
            this.type = "Candy";
        }

        // methods:
        public void AddTaste() {
            System.Console.WriteLine("Type taste:");
            string input = Console.ReadLine();
            this.taste = input;
        }

        public void AddCount() {
            System.Console.WriteLine("Type count:");
            string input = Console.ReadLine();
            this.count = input;
        }

        // public void AddToList(Candy bag) {
        //     candyList.Add(bag);
        // }

        // public void PrintList(){
        //     foreach (var candy in candyList)
        //     {   
        //         Console.WriteLine("Produkt:{0}", candy.type);
        //         Console.WriteLine("Taste:{0}", candy.taste);
        //         Console.WriteLine("Count:{0}", candy.count);
        //     }
        // }
    }

}