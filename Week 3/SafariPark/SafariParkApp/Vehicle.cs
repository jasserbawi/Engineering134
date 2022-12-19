using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SafariParkApp
{
    public class Vehicle
    {
        private int _capacity;
        private int _numPassengers;

        public int NumPassengers
        {
            get
            {
                return _numPassengers;
            }
            set
            {
                if (value >= 0 && value <= _capacity) _numPassengers = value;
            }
        }

        public int Position { get; private set; }

        public int Speed { get; init; }

        public string Move()
        {
            Position += Speed;
            return "Moving along";
        }

        public string Move(int times)
        {
            Position += times * Speed;
            return $"Moving along {times} times";
        }

        //Constructors
        public Vehicle()
        {
            Speed = 10;
        }

        public Vehicle(int capacity, int speed = 10)
        {
            _capacity = capacity;
            Speed = speed;
        }

    }
}