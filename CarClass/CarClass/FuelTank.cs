using System;
using System.Collections.Generic;
using System.Text;

namespace CarClass
{
    class FuelTank
    {
        private int _capacity;
        public int Capacity
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

        private int _level;
        public int Level
        {
            get
            {
                return _level;
            }
            set
            {
                _level = value;
            }
        }

        // Constructors
        public FuelTank()
        {
            Capacity = 50;
            Level = 50;
        }

        // Methods

        public void BurnFuel(double litres)
        {

        }

        public void Fill(double litres)
        {

        }
    }
}
