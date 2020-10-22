using System;
using System.Collections.Generic;
using System.Text;

namespace CarClass
{
    class Odometer
    {
        private double _counter;
        public double Counter 
        {
            get
            {
                return _counter;
            }
            set
            {
                if(value > 999999)
                {
                    _counter = value - 999999;
                }
                else 
                {
                    _counter = value;
                }
            }
        }
        // Default constructor
        public Odometer()
        {
            Counter = 0;
        }

        public Odometer(double counter)
        {
            Counter = counter;
        }

        public void Increment(double amount)
        {
            Counter += amount;
        }
    }
}
