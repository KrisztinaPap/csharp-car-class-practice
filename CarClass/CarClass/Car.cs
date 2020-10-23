using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Security;
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
            FuelEfficiency = 7;
            Counter = new Odometer(999990);
            Tank = new FuelTank(40);
        }

        public Car(string make, string model, string color, int maximumOccupancy, double fuelEfficiency, Odometer counter, FuelTank tank)
        {
            Make = make;
            Model = model;
            Color = color;
            MaximumOccupancy = maximumOccupancy;
            FuelEfficiency = fuelEfficiency;
            Counter = counter;
            Tank = tank;
        }

        // Methods
        public void Drive() // I'm assuming the car is driven 5km
        {
            Tank.BurnFuel(5);
            Counter.Increment(5);
        }

        public void Drive(double km)
        {
            Tank.BurnFuel(km/FuelEfficiency);
            Counter.Increment(km);
        }

        public override string ToString()
        {

            // Citation: 
            // https://stackoverflow.com/questions/4325267/c-sharp-convert-int-to-string-with-padding-zeros#4325289
            string newString = Counter.Counter.ToString("000000");
            double result = Math.Round((Tank.Level * FuelEfficiency),2);
            return $"A {Color} {Make} {Model} with {newString} on the odometer, that has enough fuel to travel {result}KM.";
        }

    }
}
