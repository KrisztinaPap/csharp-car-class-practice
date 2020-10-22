using System;
using System.Collections.Generic;
using System.Text;

namespace CarClass
{
    class FuelTank
    {
        private double _capacity;
        public double Capacity
        {
            get
            {
                return _capacity;
            }
            set
            {
                _capacity = value;
            }
        }

        private double _level;
        public double Level
        {
            get
            {
                return _level;
            }
            set
            {
                if (value > Capacity)
                {
                    Console.WriteLine("Level cannot go above capacity!");
                    _level = Capacity;
                }
                else if (value < 0)
                {
                    throw new Exception("Level cannot go below 0 litres!");
                }
                else
                {
                    try
                    {
                        _level = value;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"Error: {e.Message}");
                    }
                }
            }
        }

        // Constructors
        public FuelTank(double litres)
        {
            Capacity = 50;
            Level = litres;
        }

        public FuelTank()
        {
            Capacity = 50;
            Level = 50;
        }

        // Methods

        public double BurnFuel(double litres)
        {
            Level = Math.Round((Level - litres),2);
            return Level;
        }

        public double Fill(double litres)
        {
            Level = Math.Round((Level + litres),2);
            return Level;
        }
    }
}
