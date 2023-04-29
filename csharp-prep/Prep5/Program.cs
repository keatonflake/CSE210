using System;

class Program
{
    static void Main(string[] args)
    {
    // DisplayWelcome - Displays the message, "Welcome to the Program!"
    // PromptUserName - Asks for and returns the user's name (as a string)
    // PromptUserNumber - Asks for and returns the user's favorite number (as an integer)
    // SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)
    // DisplayResult - Accepts the user's name and the squared number and displays them.
    DisplayWelcome();
    
    string name = PromptUserName();
    int number = PromptUserNumber();
    int squared = SquareNumber(number);
    
    DisplayResult(name,squared);
    }
    
    static void DisplayWelcome(){
        Console.WriteLine("Welcome to the program! ");
    }
    static string PromptUserName(){
        Console.WriteLine("What is your name? ");
        string name = Console.ReadLine();
        Console.WriteLine($"Hey {name} whats up dawg ");
        return name;
    }
    static int PromptUserNumber(){
        Console.WriteLine("What is your favorite number? ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }
    static int SquareNumber(int number){
       int squared = number * number;
       return squared;
    }
    static void DisplayResult(string name, int squared){
        Console.WriteLine($"{name}'s favorite number squared is {squared}");
    }
}