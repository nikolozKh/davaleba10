using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace davaleba10
{
    internal class Car : Vehicle
    {

        public Car()
        {
            
        }
        public Car(double speed)
            : base(speed) 
        {
            
        }

        public void Honk()
        {
            Console.WriteLine("Honk");
        }
    }
}
