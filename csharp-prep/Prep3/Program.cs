using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("state the magic number: ");
        // string input = Console.ReadLine();
        // int magicNumber = int.Parse(input);
        Random generator = new Random();
        int magicNumber = generator.Next(1,101);
        Console.WriteLine("Now guess the Magic number: ");
        string guessInput = Console.ReadLine();
        int guess = int.Parse(guessInput);

        while (magicNumber != guess){
            if (magicNumber < guess){
                Console.WriteLine("Guess Lower! ");
                Console.WriteLine("Guess the Magic number: ");
                guessInput = Console.ReadLine();
                guess = int.Parse(guessInput);
            }
            else{
                Console.WriteLine("Guess Higher: ");
                Console.WriteLine("Guess the Magic number: ");
                guessInput = Console.ReadLine();
                guess = int.Parse(guessInput);
            }
        }
        
        if (magicNumber == guess) {
            Console.WriteLine("Nailed it! ");
        }
    }
}