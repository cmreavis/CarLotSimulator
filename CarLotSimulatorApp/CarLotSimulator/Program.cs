using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property

            List<CarLot> Inventory = new List<CarLot>();

            //Now that the Car class is created we can instanciate 3 new cars


            //Car #1 properties set
            Car redCar = new Car()
            {
                Year = 2022,
                Make = "Chevrolet",
                Model = "Malibu",
                EngineNoise = "Brrrrr",
                HonkNoise = "Beep",
                IsDriveable = true,
            };
            //Car 1 added to inventory list
            Inventory.Add(new CarLot() { Year = 2022, Make = "Chevrolet", Model = "Malibu" });

            //Car #2 properties set
            Car blackCar = new Car(2011, "BMW", "3", "Mmmmmstututu", "LautesHupen", false);
            //Car 2 added to inventory list
            Inventory.Add(new CarLot() { Year = 2011, Make = "BMW", Model = "3" });

            //Car #3 properties set
            var whiteCar = new Car();

            whiteCar.Year = 2018;
            whiteCar.Make = "Tesla";
            whiteCar.Model = "S";
            whiteCar.EngineNoise = "...";
            whiteCar.HonkNoise = "Badoop";
            whiteCar.IsDriveable = true;
            //Car 3 added to inventory list
            Inventory.Add(new CarLot() { Year = 2018, Make = "Tesla", Model = "S" });

            //Set the properties for each of the cars ^

            //Call each of the methods for each car
            redCar.MakeEngineNoise();
            redCar.MakeHonkNoise();
            Console.WriteLine();

            blackCar.MakeEngineNoise();
            blackCar.MakeHonkNoise();
            Console.WriteLine();

            whiteCar.MakeEngineNoise();
            whiteCar.MakeHonkNoise();
            Console.WriteLine();

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car ^

            //*************BONUS X 2*************//

            //Create a CarLot class ^
            //It should have at least one property: a List of cars ^
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list. ^
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            Console.WriteLine($"We currently have {Inventory.Count} vehicles in stock. Here are their specifications:");
            Console.WriteLine();
                foreach (var item in Inventory)
                    {
                        item.PrintCarSpecs();
                        Console.WriteLine();
                    }
        }
    }
}
