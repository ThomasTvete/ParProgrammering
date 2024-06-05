using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chatbot
{
    internal class Admin
    {
        private List<Chatbot> _createdChatbots = new List<Chatbot>();
        public void Run()
        {
            Console.WriteLine("Velkommen til chatbotgeneratoren");
            if (_createdChatbots.Count == 0)
            {
                CreateChatbot();

            }
            else
            {
                ConsoleLines.TopMenu();
                UserChoice();
            }
        }

        private void UserChoice()
        {
            bool isValid = false;
            string userInput = Console.ReadLine();
            while (!isValid)
            {
                if (int.TryParse(userInput, out int choice) && choice == 1 || choice == 2)
                {
                    if (choice == 1)
                    {
                        CreateChatbot();
                    }
                    else if (choice == 2)
                    {
                        ConsoleLines.ShowAllBots(_createdChatbots);
                        Run();
                    }

                    isValid = true;
                }
                else
                {
                    ConsoleLines.PrintLine("Prøv igjen");
                    userInput = Console.ReadLine();

                }
            }
        }


        public void CreateChatbot()
        {
            string userGenName = ConsoleLines.Prompt("Hva heter din bot?");
            List<string> userGenAnswers
                = ConsoleLines.CreateAnswers(
                    "Vennligst skriv inn svarene du vil at botten skal returnere (trykk blank enter for å avslutte)");
            Chatbot userGenChatbot = new Chatbot(userGenName, userGenAnswers);
            _createdChatbots.Add(userGenChatbot);
            ConsoleLines.PrintLine($"Du har lagt til {userGenName}");
            Run();
        }
    }
}