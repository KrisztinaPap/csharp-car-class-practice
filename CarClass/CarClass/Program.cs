using System;

namespace CarClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Console.WriteLine(
                $"We made a new instance of a default car:\n" +
                $"Make: {car.Make},\n" +
                $"Model: {car.Model},\n" +
                $"Color: {car.Color},\n" +
                $"Maximum Occupancy: {car.MaximumOccupancy},\n" +
                $"Fuel Efficiency: {car.FuelEfficiency},\n" +
                $"Odometer: {car.Counter.Counter},\n" +
                $"Fuel Tank: {car.Tank.Level}."
            );

            Console.WriteLine($"The car has {car.Tank.Level} Litres of gas initially.");

            car.Tank.BurnFuel(10);


            Console.WriteLine($"The car has {car.Tank.Level} Litres of gas after burning 10 L of fuel.");

            car.Tank.Fill(20);

            Console.WriteLine($"The car has {car.Tank.Level} Litres of gas after putting 20 L in the tank.");

            car.Drive();

            Car customCar = new Car("Toyota", "Matrix", "sun", 4, 4.2, new Odometer(30), new FuelTank(30));
            Console.WriteLine(
                $"We made a new instance of a custom car: \n" +
                $"Make: {customCar.Make},\n" +
                $"Model: {customCar.Model},\n" + 
                $"Color: {customCar.Color},\n" +
                $"Maximum Occupancy: {customCar.MaximumOccupancy},\n" +
                $"Fuel Efficiency: {customCar.FuelEfficiency},\n" +
                // Aaron Barthel helped me figure out how to properly display the object values
                $"Odometer: {customCar.Counter.Counter},\n" +
                $"Fuel Tank: {customCar.Tank.Level}."
            );

           

        }
    }
}
