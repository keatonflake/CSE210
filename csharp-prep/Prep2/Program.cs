using System;

class Program
{
    static void Main(string[] args)
    {

        int A = 90;
        int B = 80;
        int C = 70;
        int D = 60;

        Console.WriteLine("Hello! Type your grade percentage... ");
        string input = Console.ReadLine();
        int grade = int.Parse(input);

        if (grade >= A){
        Console.WriteLine("you got an A!! ");
        }
        else if (grade >= B){
        Console.WriteLine("you got an B! ");
        }
        else if (grade >= C){
        Console.WriteLine("you got an C! ");
        }
        else if (grade >= D){
        Console.WriteLine("you got an D! ");
        }
        else{
        Console.WriteLine("you got an F! ");
        }

        if (grade >= C){
        Console.WriteLine("you passed! ");
        }
        else{
        Console.WriteLine("you can do better! ");
        }


    }
}