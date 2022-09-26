using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    public class CarLot 
    {
        public List<Car> Inventory { get; set; }

        //Properties
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }

        public void PrintCarSpecs()
        {
            Console.WriteLine($"Model year: {Year}");
            Console.WriteLine($"Manufacturer: {Make}");
            Console.WriteLine($"Model: {Model}");
        }

        public static int numberOfCars;

        public static void GetCars()
        {
            Console.WriteLine(numberOfCars);
        }
    }
}
