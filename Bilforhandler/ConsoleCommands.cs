using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Bilforhandler
{
    public static class ConsoleCommands
    {
        public static string AskForUserData(string message)
        {
            var output = "";
            while (string.IsNullOrWhiteSpace(output))
            {
                Console.Write(message);
                output = Console.ReadLine();

            }
            

            return output;
        }

        public static void ChoiceMenu(List<Car> cars)
        {
            var count = 1;
            Console.WriteLine("Dette er bilene vi har til salgs:");

            foreach (var car in cars)
            {
                Console.WriteLine($"{count}. {car.Brand}");
                count++;
            }

        }

        public static void WelcomeMenu()
        {
            Console.WriteLine("Velkommen til Kjells Bruktbiler!");
            Console.WriteLine("1. Se biler");
            Console.WriteLine("2. Søk bil etter årstall");
            Console.WriteLine("3. Søk bil etter kilometerstand");
        }

        public static void PrintHeader()
        {
            Console.WriteLine(@"  ___ ___  __       __ __          _______            __    __   __    __ __            
 |   Y   )|__.-----|  |  .-----.  |   _   .----.--.--|  |--|  |_|  |--|__|  .-----.----.
 |.  1  / |  |  -__|  |  |__ --|  |.  1   |   _|  |  |    <|   _|  _  |  |  |  -__|   _|
 |.  _  \ |  |_____|__|__|_____|  |.  _   |__| |_____|__|__|____|_____|__|__|_____|__|  
 |:  |   |___|                    |:  1    \                                            
 |::.| .  )                       |::.. .  /                                            
 `--- ---'                        `-------'");
        }

        public static void PrintError()
        {
            Console.WriteLine("Velg ett gyldig tall");
        }

        public static void PrintOutOfStock()
        {
            Console.WriteLine("Vi har dessverre ingen biler som matcher dine kriterier");
        }

        

        

        public static void LookCar(Car car, Bilforhandler seller)
        {
            
            Console.WriteLine($"Dette er en {car.Brand} fra {car.Vintage} med registreringsnummer {car.RegNum} som har kjørt {car.DistanceTraveled}km");
            var output = AskForUserData("Vil du kjøpe denne bilen Y/N: ");
            switch (output.ToUpper())
            {
                case "Y":
                    seller.Kunde.PurchaseCar(car);
                    seller.CarsForPurchase.Remove(car);
                    break; 
                case "N":
                    break;
                break;
                default:
                    LookCar(car, seller);
                    break;


            }

        }

       
    }
}
