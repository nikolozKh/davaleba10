using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace davaleba10
{
    internal class Vehicle
    {
        protected double _speed;

        public double Speed { get { return _speed; } set { _speed = value; } }

        public Vehicle()
        {
            
        }
        public Vehicle(double speed)
        {
             this.Speed = speed;
        }

        public void Move()
        {
            Console.WriteLine("car is Moving");
        }

        public void print() {
            Console.WriteLine($"Speed: {Speed} km/hr");
        }
    }
}
