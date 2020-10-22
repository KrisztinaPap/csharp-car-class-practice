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
            Console.WriteLine(car);
            car.Drive();
            Console.WriteLine($"After driving, the car has {car.Tank.Level} Litres of gas and the odometer shows {car.Counter.Counter} kms.");
            Console.WriteLine(car);
            car.Drive(20);
            Console.WriteLine($"After driving 20 kms, the car has {car.Tank.Level} Litres of gas and the odometer shows {car.Counter.Counter} kms.");
            Console.WriteLine(car);
            car.Tank.Fill(20);
            Console.WriteLine($"After putting 20 L in the tank, the car has {car.Tank.Level} Litres of gas and the odometer shows {car.Counter.Counter} kms.");
            Console.WriteLine(car);
            car.Tank.Fill(20);
            car.Drive(30);
            Console.WriteLine($"After driving 30 kms (and getting 20 L of gas), the car has {car.Tank.Level} Litres of gas and the odometer shows {car.Counter.Counter} kms.");
            Console.WriteLine(car);


            // Testing custom car
            Car customCar = new Car("Toyota", "Matrix", "gray", 4, 4.2, new Odometer(30), new FuelTank(30));
            Console.WriteLine(customCar);
            customCar.Drive(20);
            Console.WriteLine(customCar);
            customCar.Tank.Fill(15);
            Console.WriteLine(customCar);
        }
    }
}
