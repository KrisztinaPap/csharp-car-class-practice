using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CarClass
{
    class Car
    {
        // Properties
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int MaximumOccupancy { get; set; }
        public double FuelEfficiency { get; set; }
        public Odometer Counter { get; set; }
        public FuelTank Tank { get; set; }


        // Constructors
        public Car()
        {
            Make = "Toyota";
            Model = "Camry";
            Color = "blue";
            MaximumOccupancy = 4;
            FuelEfficiency = 4.25;
            Counter = 5000;
            tank = 45;
        }

        public Car(string make, string model, string color, int maximumOccupancy, double fuelEfficiency, Odometer counter, FuelTank tank)
        {
            Make = make;
            Model = model;
            Color = color;
            MaximumOccupancy = maximumOccupancy;
            FuelEfficiency = fuelEfficiency;
            Counter = counter;
            tank = tank;
        }

        // Methods
        public void Drive()
        {

        }

        public void Drive(km)
        {

        }

        public override string ToString()
        {
            double result = 0.00;
            return $"A {Color} {Make} {Model} with {Counter} on the odometer, that has enough fuel to travel {result}";
        }

    }
}
