using System;

class Program
{
    // In this program I completed all the core requirements as well as:

    // 1) Making the program loop so the user can do additional activities 
    // without restarting the program
    // 2) Saving the selected random prompt and all responses to a text file
    // called "Answers" for the user to save as a journal.
    static void Main(string[] args)
    {
        bool runAgain = true;

        while (runAgain)
        {
            Console.WriteLine();
            Console.WriteLine("Welcome! \nChoose one of the following activities\nTo start, type the corresponding number: ");
            Console.WriteLine();
            Console.WriteLine("1) Breathing Activity \n2) Reflection \n3) Listing \n4) quit");
            string _input = Console.ReadLine();
            int _activity = Int32.Parse(_input);

            switch (_activity)
            {
                case 1:
                    Breathe newBreate = new Breathe();
                    newBreate.GetTime();
                    Console.Clear();
                    newBreate.GetStartingMessage();
                    newBreate.StartActivity();
                    newBreate.GetEndingMessage();
                    Console.Clear();
                    break;
                case 2:
                    Reflect newReflect = new Reflect();
                    newReflect.GetTime();
                    Console.Clear();

                    Console.WriteLine();
                    newReflect.GetStartingMessage();
                    newReflect.ShowSpinner(3);

                    newReflect.StartActivity();

                    newReflect.GetEndingMessage();
                    newReflect.ShowSpinner(3);
                    Console.Clear();

                    break;
                case 3:
                    Listing newListing = new Listing();
                    newListing.GetTime();
                    Console.Clear();

                    newListing.GetStartingMessage();

                    newListing.StartActivity();

                    newListing.GetEndingMessage();
                    Console.Clear();
                    break;
                case 4:
                    Console.WriteLine("Have a great day!");
                    runAgain = false;
                    break;
            }
        }
    }
}