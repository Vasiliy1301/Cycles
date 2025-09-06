namespace Cycles;

public class Program
{
    #region Task 1
    Console.WriteLine("Enter the number of employees: ");
    int NumberOfEmployees = Convert.ToInt32(Console.ReadLine());

    double AmountOfSalary = 0;
    double TotalSalary = 0;

    for (int i = 1; i <= NumberOfEmployees; i++)
    {
        Console.Write($"Enter the salary amount for the {i} employee in dollars: ");
        AmountOfSalary = Convert.ToDouble(Console.ReadLine());
        TotalSalary += AmountOfSalary;
    }

    Console.WriteLine($"The total salary is {TotalSalary} dollars, the total number of employees is {NumberOfEmployees}," +
                      $"the average salary per employee is {TotalSalary / NumberOfEmployees} dollars.");
    #endregion
    
    
    #region Task 2
    Console.WriteLine("Enter the number of stars: ");
    int Stars = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Result: ");

    for (int i = 1; i <= Stars; i++)
    {
        Console.WriteLine(new string('*', i));
    }
    #endregion
    
    
    #region Task 6
    int Hours = 0;
    int TotalHours = 0;
    double StartingPrice = 10;
    double TotalAmount = 0;

    Console.Write($"You start working, today your starting rate per hour of work is {StartingPrice}$, " +
    $"for each subsequent hour you will receive one dollar more than the starting rate.\n");

    for (int i = 0; i < 3; i++)
    {
        Console.WriteLine("Enter how many hours you worked today: ");
        Hours = Convert.ToInt32(Console.ReadLine());
    
        for (int j = 0; j < Hours; j++)
        {
            TotalAmount += StartingPrice;
            StartingPrice++;
        }
    
        TotalHours += Hours;

        Console.Write($"You have worked {Hours} hours today and earned {TotalAmount}$, your bet is now {StartingPrice}$.\n");
    }

    Console.Write($"\nYou worked {TotalHours} hours and earned {TotalAmount}$ today.");
    #endregion
    
    
    #region Task 7
    Console.WriteLine("Enter number: ");
    int Number = Convert.ToInt32(Console.ReadLine());
    int Result = 0;

        if (Number >= 1 && Number <= 10)
    {
        for (int i = 1; i <= 10; i++)
        {
            Result = Number * i;
            Console.WriteLine($"{Number} * {i} = {Number * i}");
        }
    }
    else
    Console.WriteLine("Enter a number from 1 to 10");
    #endregion
}