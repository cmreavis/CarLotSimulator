﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    public class Car
    {
        //Properties
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }

        //Methods
        public void MakeEngineNoise()
        {
            Console.WriteLine($"{EngineNoise}!");
        }

        public void MakeHonkNoise()
        {
            Console.WriteLine($"{HonkNoise}!");
        }
        //Recreating default constructor
        public Car()
        {
        }
        //Parameterized constructor
        public int year;
        public string make, model, engineNoise, honkNoise;
        public bool isDriveable;
        public Car(int year, string make, string model, string engineNoise, string honkNoise, bool isDriveable)
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDriveable = isDriveable;

            
        }
    }


    
}
