using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Bilforhandler
{
    public abstract class Car
    {
        public string Brand { get; private set; }
        public int Vintage { get; private set; }
        public string RegNum { get; private set; }
        public double DistanceTraveled { get; private set; }

        protected Car(string brand, int vintage, string reg, double distance)
        {
            Brand = brand;
            Vintage = vintage;
            RegNum = reg;
            DistanceTraveled = distance;
        }

        public virtual void StartCar()
        {
            Console.WriteLine("You put the key in the ignition");
        }

        public abstract void StopCar();


    }
}
