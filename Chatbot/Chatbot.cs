using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chatbot
{
    public class Chatbot
    {
        public string Name { get; private set; }
        public List<string> ListOfAnswers;

        public Chatbot(string name, List<string> answers)
        {
            Name = name;
            ListOfAnswers = answers;
        }

        public void BootUp()
        {
            Console.Clear();
            ConsoleLines.PrintLine($"Hallo, jeg er {Name}.");
            ConsoleLines.PrintLine("Du har kommet til meg i søken etter min endeløse visdom");
            ConsoleLines.PrintLine("Spør meg hva enn du lurer på:");
            ConsoleLines.BotPrompt(ListOfAnswers);

        }
    }
}