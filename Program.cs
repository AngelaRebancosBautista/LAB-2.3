using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> ages = new List<int>();
        Console.WriteLine("Enter at least 20 age entries (type 'done' to finish):");

        while (ages.Count < 20)
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "done" && ages.Count >= 20)
                break;

            if (int.TryParse(input, out int age) && age >= 0)
            {
                ages.Add(age);
            }
            else
            {
                Console.WriteLine("Please enter a valid age or type 'done' to finish.");
            }
        }


        double average = ages.Average();
        int min = ages.Min();
        int max = ages.Max();
        int countUnder18 = ages.Count(a => a < 18);
        int count18To35 = ages.Count(a => a >= 18 && a <= 35);
        int count36To60 = ages.Count(a => a >= 36 && a <= 60);
        int countOver60 = ages.Count(a => a > 60);


        Console.WriteLine("\nAge Statistics:");

        Console.WriteLine(" Metric                   Value              ");
        Console.WriteLine("---------------------------------------------");
        Console.WriteLine($"  Average Age             {average:F2}      ");
        Console.WriteLine($"  Minimum Age             {min}             ");
        Console.WriteLine($"  Maximum Age             {max}             ");

        Console.WriteLine(" Age Bracket              Count              ");
        Console.WriteLine("---------------------------------------------");
        Console.WriteLine($"  < 18                    {countUnder18}    ");
        Console.WriteLine($"  18 - 35                 {count18To35}     ");
        Console.WriteLine($"  36 - 60                 {count36To60}     ");
        Console.WriteLine($"  > 60                    {countOver60}     ");
    }
}
