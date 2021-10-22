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

                LineBreak();
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
            LineBreak();
            IterateListItem(names);

            //and the total number of guests.
            LineBreak();
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
            // This method basically allows user to ask question where he get integer in return.
            Console.Write(message);
            string outputText = Console.ReadLine();

            //Below line will basically perform two task
            //1. It will try to convert string into integer.
            //2nd : if the string in number format then it will return true and also assign that converted integer into another variable.
            bool isValidInput = int.TryParse(outputText, out int output);

            //this below line will check if the isValidInput bool has a true value.
            //if its true than the converted value assign to the output variable.
            if (isValidInput)
            {
                return output;
            }
            else
            {
                //this block of code runs when the string input is not given as integer string format and then the below message will print out
                //I have used while loop so that I can force user to enter the correct value in integer format. 
                do
                {
                    Console.WriteLine("Please enter the value in correct format (integer)");
                    Console.Write(message);
                    outputText = Console.ReadLine();

                    isValidInput = int.TryParse(outputText, out output);
                } while (isValidInput == !true);
                // Above line siginigfies that if the value is not correct then this loop will again run till the user doesnt give the value in correct format
            }

            return output; 
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

        private static void LineBreak()
        {
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}