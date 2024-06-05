using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilforhandler
{
    public class Kunde
    {
        public string Navn { get; private set; }
        public List<Car> OwnedCars { get; private set; } = new List<Car>();

        public void PurchaseCar(Car car)
        {
           OwnedCars.Add(car);
        }
    }
}
