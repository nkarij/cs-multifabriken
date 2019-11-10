using System;
using System.Collections.Generic;

namespace cs_multifabriken1 {

    public class ProductTypev1 {

        public string type;
        public List<object> productList = new List<object>();

        public void AddToList(object product) {
            productList.Add(product);
        }

        public void PrintList() {
            // loop list
            foreach (var product in productList)
            {
                // get properties
                var props = product.GetType().GetProperties();
                // der er ingen props???
                Console.WriteLine(props[0]);
                // loop props
                foreach (var prop in props)
                {   
                    System.Console.WriteLine("Inde i loop");
                    Console.WriteLine(prop.GetValue(product, null));
                }
            }

        }

    }
}