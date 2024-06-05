using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Bilforhandler
{
    public class Nissan : Car
    {
        public int MaxSpeed { get; set; }
        public Nissan(string brand, int vintage, string reg, double distance, int maxSpeed) : base(brand, vintage, reg, distance)
        {
            MaxSpeed = maxSpeed;
        }

        public override void StartCar()
        {
            base.StartCar();
            Console.WriteLine($"the engine of the {Brand} hums to life");
        }

        public override void StopCar()
        {
            Console.WriteLine($"You slam the breaks and the {Brand} stops in a few meters");
        }
    }
}
