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
}