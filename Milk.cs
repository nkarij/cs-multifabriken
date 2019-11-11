using System;
using System.Collections.Generic;

namespace cs_multifabriken1 {

    class Milk : ProductTypev1 {

        // attributes
        public string fat;
        public string liter;

        public Milk(){
            // type inherited from productType
            this.type = "Milk";
        }

        // methods:
        public void AddFat() {
            System.Console.WriteLine("How much fat:");
            string input = Console.ReadLine();
            this.fat = input;
        }

        public void AddLiter() {
            System.Console.WriteLine("Type liter:");
            string input = Console.ReadLine();
            this.liter = input;
        }

        // public void AddToList(Milk bottle) {
        //     milkList.Add(bottle);
        // }

        // public void PrintList(){
        //     foreach (var milk in milkList)
        //     {   
        //         Console.WriteLine("Produkt:{0}", milk.type);
        //         Console.WriteLine("Fat:{0}", milk.fat);
        //         Console.WriteLine("Liter:{0}", milk.liter);
        //     }
        // }
    }

}