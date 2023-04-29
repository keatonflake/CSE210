using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("iTS wOrKiNG!!! ");
        // Compute the sum, or total, of the numbers in the list.
        // Compute the average of the numbers in the list.
        // Find the maximum, or largest, number in the list.
        bool repeat = true;
        var numbers = new List<int>();
        int sum = 0;
        float average = 0;
        int count = 0;
        int biggest = 0;
        int smallest = 1000000;
        while (repeat){
            Console.WriteLine("Type Numbers to add to the list. When done enter the number 0");
            int newNumber = int.Parse(Console.ReadLine());
            numbers.Add(newNumber);

            if (newNumber == 0){
                repeat = false;
            }
        }
        foreach (int number in numbers){
            sum += number;
            count += 1;
            average = sum / count;
            if (number > biggest){
                biggest = number;
            } 
            if (number != 0){
                if (smallest > number){
                    smallest = number;
                }
            }
        }
        Console.WriteLine(sum);
        Console.WriteLine(average);
        Console.WriteLine(biggest);
        Console.WriteLine(smallest);


    }
}