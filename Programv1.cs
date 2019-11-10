using System;

namespace cs_multifabriken1
{
    class Programv1
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("");
            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("[1] add car");
                Console.WriteLine("[5] print list of products");
                Console.WriteLine("[6] close program");
                string input = Console.ReadLine();
                int option = Convert.ToInt32(input);

                switch (option)
                {
                    case 1: 
                        // create new instance, add license, color, model
                        Carv1 newCar = new Carv1();
                        System.Console.WriteLine("Type License number:");
                        string license = Console.ReadLine();
                        newCar.AddLicense(license);
                        newCar.AddColor();
                        newCar.AddModel();
                        // newCar.AddToList(newCar);
                        // print list
                        newCar.PrintList();
                        break;
                    case 5:
                        
                        break;
                    case 6:
                        Console.Clear();
                        isRunning = false;
                        return;
                    default:
                        Console.WriteLine("Type error?");
                        break;
                }
            }
        }
    }
}
