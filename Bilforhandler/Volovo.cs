using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Bilforhandler
{
    public class Volovo : Car
    {
        public Volovo(string brand, int vintage, string reg, double distance) : base(brand, vintage, reg, distance)
        {
        }

        public override void StopCar()
        {
            Console.WriteLine($"bile står og brenner gummi slipp gassen");
        }
    }
}
