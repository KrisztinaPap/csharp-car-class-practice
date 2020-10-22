using System;
using System.Collections.Generic;
using System.Text;

namespace CarClass
{
    class Odometer
    {
        private int _counter;
        public int Counter 
        {
            get
            {
                return _counter;
            }
            set
            {
                _counter = value;
            }
        }

        public Odometer(int counter)
        {
            Counter = counter;
        }

        public void Increment(amount)
        {

        }
    }
}
