using System;
using System.Collections.Generic;

namespace cs_multifabriken1
{
    class Programv1
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("");
            bool isRunning = true;
            // lists
            List<Carv1> carList = new List<Carv1>();
            List<Milk> milkList = new List<Milk>();
            List<Pipe> pipeList = new List<Pipe>();
            List<Candy> candyList = new List<Candy>();

            while (isRunning)
            {
                Console.WriteLine("[1] add car");
                Console.WriteLine("[2] add Milk");
                Console.WriteLine("[3] add Pipe");
                Console.WriteLine("[4] add Candy");
                Console.WriteLine("[5] print list of products");
                Console.WriteLine("[6] close program");
                string input = Console.ReadLine();
                int option = Convert.ToInt32(input);

                switch (option)
                {
                    case 1: 
                        // create new instance, add license, color, model
                        Carv1 newCar = new Carv1();
                        newCar.AddLicense();
                        newCar.AddColor();
                        newCar.AddModel();
                        carList.Add(newCar);
                        break;
                    case 2:
                        Milk newMilk = new Milk();
                        newMilk.AddFat();
                        newMilk.AddLiter();
                        milkList.Add(newMilk);
                        break;
                    case 3: 
                        Pipe newPipe = new Pipe();
                        newPipe.AddDiameter();
                        newPipe.AddLength();
                        pipeList.Add(newPipe);
                        break;
                    case 4:
                        Candy newCandy = new Candy();
                        newCandy.AddTaste();
                        newCandy.AddCount();
                        candyList.Add(newCandy);
                        break;
                    case 5:
                        foreach (var car in carList)
                        {
                            Console.WriteLine("PRODUCT:{0}", car.type);
                            Console.WriteLine("License:{0}", car.licenseNumber);
                            Console.WriteLine("Model:{0}", car.model);
                            Console.WriteLine("Color:{0}", car.color);
                        }
                        foreach (var milk in milkList)
                        {   
                            Console.WriteLine("PRODUCT:{0}", milk.type);
                            Console.WriteLine("Fat:{0}", milk.fat);
                            Console.WriteLine("Liter:{0}", milk.liter);
                        }
                        foreach (var pipe in pipeList)
                        {   
                            Console.WriteLine("PRODUCT:{0}", pipe.type);
                            Console.WriteLine("Diameter:{0}", pipe.diameter);
                            Console.WriteLine("Length:{0}", pipe.length);
                        }
                        foreach (var candy in candyList)
                        {   
                            Console.WriteLine("PRODUCT:{0}", candy.type);
                            Console.WriteLine("Taste:{0}", candy.taste);
                            Console.WriteLine("Count:{0}", candy.count);
                        }
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
