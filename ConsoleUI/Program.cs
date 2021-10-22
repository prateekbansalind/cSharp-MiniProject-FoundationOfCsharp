using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Build a Console Guest Book.
            WelcomeMessage();

            List<string> names = new List<string>();
            List<int> totalMembers = new List<int>();

            string decisionVar;

            do
            {

                Console.WriteLine();
                //Ask the user for their name
                string name = AskQuestion("What is your name: ");

                //and how many are in their party.
                int noOfMember = AskQuestionInt("How many guest are with you?: ");
               
                names.Add(name);
                totalMembers.Add(noOfMember);

                //Keep track of how many people are at the party.
                Console.WriteLine($"Current number of people in the party: {SumArrayInListOfInteger(totalMembers)}");
                

                decisionVar = AskQuestion("Do you want to make another entry (y/n): ");

            } while (decisionVar.ToLower() == "y");


            //At the end, print out the guest list
            Console.WriteLine();
            IterateListItem(names);

            //and the total number of guests.
            Console.WriteLine();
            Console.WriteLine($"Total Number of guest present in the party are {SumArrayInListOfInteger(totalMembers)}");

           Console.ReadLine();
        }

         private static void WelcomeMessage()
        {
            Console.WriteLine("************************************************************");
            Console.WriteLine("**************** Welcome to the party club ****************");
            Console.WriteLine("************************************************************");
            Console.WriteLine();
        }

         private static string AskQuestion(string message)
        {
            Console.Write(message);
            string output = Console.ReadLine();

            return output;
        }

         private static int AskQuestionInt (string message)
        {
            Console.Write(message);
            string outputText = Console.ReadLine();

            bool isValidInput = int.TryParse(outputText, out int output);

            if (isValidInput)
            {
                return output;
            }
            else
                return 0;
        }

         private static void IterateListItem (List<string> listName)
        {
            foreach (string item in listName)
            {
                Console.WriteLine($"{item}");
            }
        } 

         private static int SumArrayInListOfInteger (List<int> listName)
        {
            int output = 0;

            for (int i = 0; i < listName.Count; i++)
            {
                output += listName[i];
            }
            return output;
        }
    }
}