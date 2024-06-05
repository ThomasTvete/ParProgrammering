using Microsoft.VisualBasic.CompilerServices;

namespace Chatbot;

public class ConsoleLines
{
    public static string Prompt(string question)
    {
        string output = "";

        while (string.IsNullOrWhiteSpace(output))
        {
            Console.WriteLine(question);
            output = Console.ReadLine();
        }

        return output;

    }

    public static void PrintLine(string line)
    {
        Console.WriteLine(line);
    }

    public static List<string> CreateAnswers(string message)
    {
        List<string> listOfAnswers = new List<string>();
        string userInput = "X";
        Console.WriteLine(message);
        while (!string.IsNullOrWhiteSpace(userInput))
        {

            userInput = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(userInput)) listOfAnswers.Add(userInput);
        }

        return listOfAnswers;
    }

    public static void BotPrompt(List<string> answerList)
    {
        Random rnd = new Random();
        string userQuestion = "X";
        while (!string.IsNullOrWhiteSpace(userQuestion))
        {
            userQuestion = Console.ReadLine();
            int index = rnd.Next(0, answerList.Count);
            Console.WriteLine(answerList[index]);
        }
    }

    public static void TopMenu()
    {
        Console.Clear();

        Console.WriteLine("Hva vil du gjøre? Skriv inn tall:");
        Console.WriteLine("1. Lag en ny chatbot");
        Console.WriteLine("2. Snakk med en bot");
    }

    public static void ShowAllBots(List<Chatbot> chatbots)
    {
        Console.WriteLine("Her er alle chatbotsa du har til nå:");
        for (int i = 0; i < chatbots.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {chatbots[i].Name}");
        }

        PickBot(chatbots);
    }

    private static void PickBot(List<Chatbot> chatbots)
    {
        bool isValid = false;
        string userInput = Console.ReadLine();
        while (!isValid)
        {
            if (int.TryParse(userInput, out int choice) && choice <= chatbots.Count)
            {
                chatbots[choice - 1].BootUp();
                isValid = true;
            }
            else
            {
                ConsoleLines.PrintLine("Prøv igjen");
                userInput = Console.ReadLine();

            }
        }
    }
}