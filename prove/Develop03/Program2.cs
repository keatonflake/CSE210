using System;

class Program
{
    static void Main(string[] args)
    {
        // This program exceeds the requirements by allowing the user to memorize a default scripture, 
        // load a file with text the user wants to memorize,
        // type in the text for the scripture He or She wants to memorize
        // the program starts by hiding 1/3 the length of the text no matter the size
        
        bool continueHiding = true;
        bool undecided = true;

        string scripture = "Wherefore my beloved brothren pray unto the Father with all the energy of heart that ye may be filled with this love which he hath bestowed upon all who are true followers of his Son Jesus Christ thay ye may become the sons of God that when he shall appear we shall be like Him for we shall see Him as He is that we may have this hope that we may be purified even as he is pure Amen";
        string book = "Moroni";
        int chapter = 7;
        int beginningVerse = 48;
        int endingVerse = 0;


        LoadScripture newLoadScripture = new LoadScripture();

        string message = string.Empty;

        while (undecided == true)
        {
            Console.WriteLine("Welcome to Scripture App!");
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Learn new scripture");
            Console.WriteLine("2. Open scripture from file");
            Console.WriteLine("3. Type in your own scripture");


            int option = ReadOption();

            switch (option)
            {
                case 1:
                    Console.WriteLine("Let's get started!!");
                    undecided = false;
                    break;
                case 2:
                    Console.WriteLine("perfect please provide a file with the text for the scripture you wish to memorize");
                    
                    scripture = newLoadScripture.OpenScriptureFromFile();
                    // if nothing is returned then keep asking for a file
                    while(scripture == ""){
                        Console.WriteLine("File appears to be empty...");
                        scripture = newLoadScripture.OpenScriptureFromFile();
                    }
                    
                    Console.WriteLine("Type the book referance for the scripture");
                    book = Console.ReadLine();
                    Console.WriteLine("Type the number for the chapter referanced");
                    chapter = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Type the number for the beginning verse referanced");
                    beginningVerse = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Type the number for the ending verse referanced **if N/A type 0");
                    endingVerse = Int32.Parse(Console.ReadLine());

                    undecided = false;
                    break;
                case 3:
                    Console.WriteLine("Type the book referance for the scripture");
                    book = Console.ReadLine();
                    Console.WriteLine("Type the number for the chapter referanced");
                    chapter = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Type the number for the beginning verse referanced");
                    beginningVerse = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Type the number for the ending verse referanced **if N/A type 0");
                    endingVerse = Int32.Parse(Console.ReadLine());

                    
                    Console.WriteLine("Perfect now enter the text you wish to memorize: ");
                    scripture = Console.ReadLine();
                    
                    undecided = false;
                    break;
                default:
                    Console.WriteLine("Invalid option!");
                    return;
            }
        }

        Referance newReferance = new Referance(book, chapter, beginningVerse, endingVerse);
        Scripture newScripture = new Scripture(scripture);

        Console.WriteLine();
        Console.WriteLine("Hit Enter to hide more words or type quit:");
        Console.WriteLine();
        Console.WriteLine(newReferance.GetString());
        newScripture.Display();

        while (continueHiding)
        {
            //  read user input
            var userInput = Console.ReadLine();
            if (userInput == "")
            {
                Console.WriteLine(newReferance.GetString());
                Console.WriteLine(newScripture.HideMore());
                continueHiding = newScripture.AllHidden();
            }
            else if (userInput.ToLower() == "quit")
            {
                continueHiding = newScripture.AllHidden();
                continueHiding = false;
            }
            else
            {
                Console.WriteLine("Hit the Enter Key or type quit...");
                continueHiding = true;
            }
        }

        static int ReadOption()
        {
            int option;
            while (!int.TryParse(Console.ReadLine(), out option))
            {
                Console.WriteLine("Invalid option! Please enter a number.");
            }
            return option;
        }
    }
}