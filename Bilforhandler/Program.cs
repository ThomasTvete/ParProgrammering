using System.Linq.Expressions;
using System.Runtime.InteropServices;

namespace Bilforhandler
{
    internal class Program
    {
        public static Kunde Tommy = new Kunde();
        public static Bilforhandler KjellBilforhandler = new Bilforhandler(Tommy);
        static void Main(string[] args)
        {
            while (true)
            {

                Console.Clear();
                ConsoleCommands.PrintHeader();
                ConsoleCommands.WelcomeMenu();
                int userChoice = Convert.ToInt32(ConsoleCommands.AskForUserData("Hva vil du gjøre? Velg tall: "));
                ChosenMenu(userChoice);
            }






        }

        public static void ChosenMenu(int input)
        {
            Console.Clear();
            ConsoleCommands.PrintHeader();
            switch (input)
            {
                case 1:
                    CarMenu();
                    break;
                case 2:
                    YearMenu(KjellBilforhandler);
                    break;
                case 3:
                    MileageMenu(KjellBilforhandler);
                    break;
                default:
                    ConsoleCommands.PrintError();
                    Console.ReadKey(true);
                    break;


            }
        }

        public static void CarMenu()
        {
            ConsoleCommands.ChoiceMenu(KjellBilforhandler.CarsForPurchase);
            int chosenCar = Convert.ToInt32(ConsoleCommands.AskForUserData("Hvilken bil vil du se på? Velg tall: "));
            var car = KjellBilforhandler.CarsForPurchase[chosenCar - 1];
            ConsoleCommands.LookCar(car, KjellBilforhandler);
        }

        public static void YearMenu(Bilforhandler seller)
        {
        List<Car> potentialCars = new List<Car>();
            int minYear = Convert.ToInt32(ConsoleCommands.AskForUserData("Skriv inn minimum årsmodell: "));
            int maxYear = Convert.ToInt32(ConsoleCommands.AskForUserData("Skriv inn maximum årsmodell: "));

            foreach (var car in seller.CarsForPurchase)
            {
                if (car.Vintage > minYear && car.Vintage < maxYear)potentialCars.Add(car);
            }

            SearchCar(seller, potentialCars);
        }

       

        public static void MileageMenu(Bilforhandler seller)
        {
            List<Car> potentialCars = new List<Car>();
            int maxMileage = Convert.ToInt32(ConsoleCommands.AskForUserData("Skriv inn maximum kilometerstand: "));
            foreach (var car in seller.CarsForPurchase)
            {
                if (car.DistanceTraveled < maxMileage) potentialCars.Add(car);
            }

            SearchCar(seller, potentialCars);
        }

        public static void SearchCar(Bilforhandler seller, List<Car> potentialCars)
        {
            Console.Clear();
            ConsoleCommands.PrintHeader();
            if (potentialCars.Count == 0)
            {
                ConsoleCommands.PrintOutOfStock();
                Console.ReadKey(true);
                return;
            }
            
            ConsoleCommands.ChoiceMenu(potentialCars);
            int chosenCarNr = Convert.ToInt32(ConsoleCommands.AskForUserData("Hvilken bil vil du se på? Velg tall: "));
            var chosenCar = seller.CarsForPurchase.Where(x => x.RegNum == potentialCars[chosenCarNr - 1].RegNum).FirstOrDefault();
            ConsoleCommands.LookCar(chosenCar, seller);
        }
    }
}
