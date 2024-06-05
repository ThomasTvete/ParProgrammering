using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilforhandler
{
    public class Bilforhandler
    {
        public List<Car> CarsForPurchase { get; private set; } = new List<Car>();
        public Kunde Kunde { get; private set; }

        public Bilforhandler(Kunde kunde)
        {
            Kunde = kunde;
            CarsForPurchase.Add(new Nissan("Nissan LEAF", 2003, "123", 190.82, 200));
            CarsForPurchase.Add(new Honda("Honda Civic", 1995, "321", 10000.87, "Brad pitt"));
            CarsForPurchase.Add(new Volovo("Volvo XC40", 1995, "rån4lyfe", 1894.37));
            CarsForPurchase.Add(new Nissan("Nissan GT-R", 2023, "yoo", 90.9, 300));
            CarsForPurchase.Add(new Honda("Honda 2025 Pilot", 2025, "p1l0t", 1, "none"));
            CarsForPurchase.Add(new Volovo("Volvo EC40", 1987, "futur3", 20084.74));
        }
    }
}
