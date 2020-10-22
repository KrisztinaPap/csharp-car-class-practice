using System;

namespace CarClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
          /*  Console.WriteLine(
                $"We made a new instance of a default car:\n" +
                $"Make: {car.Make},\n" +
                $"Model: {car.Model},\n" +
                $"Color: {car.Color},\n" +
                $"Maximum Occupancy: {car.MaximumOccupancy},\n" +
                $"Fuel Efficiency: {car.FuelEfficiency},\n" +
                $"Odometer: {car.Counter.Counter},\n" +
                $"Fuel Tank: {car.Tank.Level}."
            );*/

            Console.WriteLine($"The car starts with {car.Tank.Level} Litres of gas and the odometer shows {car.Counter.Counter} kms.");

            car.Drive();
            Console.WriteLine($"After driving, the car has {car.Tank.Level} Litres of gas and the odometer shows {car.Counter.Counter} kms.");

            car.Drive(20);
            Console.WriteLine($"After driving 20 kms, the car has {car.Tank.Level} Litres of gas and the odometer shows  {car.Counter.Counter} kms.");

            car.Tank.Fill(20);

            Console.WriteLine($"After putting 20 L in the tank, the car has {car.Tank.Level} Litres of gas and the odometer shows  {car.Counter.Counter} kms.");

            Car customCar = new Car("Toyota", "Matrix", "sun", 4, 4.2, new Odometer(30), new FuelTank(30));
           /* Console.WriteLine(
                $"We made a new instance of a custom car: \n" +
                $"Make: {customCar.Make},\n" +
                $"Model: {customCar.Model},\n" + 
                $"Color: {customCar.Color},\n" +
                $"Maximum Occupancy: {customCar.MaximumOccupancy},\n" +
                $"Fuel Efficiency: {customCar.FuelEfficiency},\n" +
                // Aaron Barthel helped me figure out how to properly display the object values
                $"Odometer: {customCar.Counter.Counter},\n" +
                $"Fuel Tank: {customCar.Tank.Level}."
            );*/

           

        }
    }
}
