namespace Cycles;

public class Program
{
    #region Task 1
    
    Console.Write("Enter the number of employees: ");
    int numberOfEmployees = Convert.ToInt32(Console.ReadLine());

    double totalSalary = 0;

    for (int i = 1; i <= numberOfEmployees; i++)
    {
        Console.Write($"Enter the salary amount for the {i} employee in dollars: ");
        double amountOfSalary = Convert.ToDouble(Console.ReadLine());
        
        totalSalary += amountOfSalary;
    }

    Console.WriteLine($"The total salary is {totalSalary} dollars, the total number of employees is {numberOfEmployees}," +
                      $" the average salary per employee is {totalSalary / numberOfEmployees} dollars.");
        
    #endregion
    
    
    #region Task 2
    
    Console.WriteLine("Enter the number of stars: ");
    int stars = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Result: ");

    for (int i = 0; i <= stars; i++)
    {
        Console.WriteLine(new string('*', i));
    }
        
    #endregion


    #region Task 3
    
    Console.Write("Enter up to what number to output prime numbers: ");
    int number = Convert.ToInt32(Console.ReadLine());

    for (int i = 2; i <= number; i++)
    {
        bool isPrime = true;

        for (int j = 2; j < i; j++)
        {
            if (i % j == 0)
            {
                isPrime = false;
                break;
            }
        }

        if (isPrime)
            Console.Write(i + " ");
    }
    
    #endregion


    #region Task 4
    
    Console.WriteLine("Create a password: ");
    string password = Console.ReadLine();

    int minimumPasswordLength = 8;

    bool passwordCorrect = false;

    while (!passwordCorrect)
    {
        if (password.Length >= minimumPasswordLength)
        {
            bool hasDigit = false;
            bool hasSpecial = false;

            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsDigit(password[i]))
                {
                    hasDigit = true;
                    break;
                }
            }

            for (int i = 0; i < password.Length; i++)
            {
                if (!char.IsLetterOrDigit(password[i]))
                {
                    hasSpecial = true;
                    break;
                }
            }

            if (hasDigit && hasSpecial)
            {
                Console.WriteLine("Your password has been accepted!");
                passwordCorrect = true;
            }
            else
            {
                Console.Write("You entered an incorrect password " +
                              "(password must contain at least 1 number and at least 1 special character).\nTry again: ");
                password = Console.ReadLine();
            }
        }
        else
        {
            Console.Write("Enter a password consisting of 8 or more characters.\nTry again: ");
            password = Console.ReadLine();
        }
    }
        
    #endregion
    
    
    #region Task 5
    
    int fibonacciNumber1 = 0;
    int fibonacciNumber2 = 1;

    Console.Write("Enter how many times to calculate the Fibonacci number: ");
    int number = Convert.ToInt32(Console.ReadLine());

    int minimumInputDigit = 1;
    int maximumInputDigit = 47;
    int startOfCounting = 2;

    if (number > minimumInputDigit && number <= maximumInputDigit)
    {
        Console.Write($"{fibonacciNumber1} {fibonacciNumber2} ");
    
        for (int i = startOfCounting; i < number; i++)
        {
            int next = fibonacciNumber1 + fibonacciNumber2;
        
            fibonacciNumber1 = fibonacciNumber2;
            fibonacciNumber2 = next;
        
            Console.Write($"{next} ");
        }
    }
    else if (number == 1)
        Console.WriteLine(fibonacciNumber1);
    else
        Console.WriteLine("Enter a valid value between 1 and 47");
    
    #endregion
    
    
    #region Task 6
    
    int totalHours = 0;
    int maximumNumberOfRequests = 3;
    double startingPrice = 10;
    double totalAmount = 0;

    Console.Write($"You start working, today your starting rate per hour of work is {startingPrice}$, " +
                  $"for each subsequent hour you will receive one dollar more than the starting rate.\n");

    for (int i = 0; i < maximumNumberOfRequests; i++)
    {
        Console.Write("Enter how many hours you worked today: ");
        int hours = Convert.ToInt32(Console.ReadLine());
    
        for (int j = 0; j < hours; j++)
        {
            totalAmount += startingPrice;
            startingPrice++;
        }
    
        totalHours += hours;

        Console.Write($"You have worked {hours} hours today and earned {totalAmount}$, your bet is now {startingPrice}$.\n");
    }

    Console.Write($"\nYou worked {totalHours} hours and earned {totalAmount}$ today.");
    
    #endregion
    
    
    #region Task 7
    
    Console.Write("Enter the number to multiply: ");
    int number = Convert.ToInt32(Console.ReadLine());

    const int MINIMUM_INPUT = 1;
    const int MAXIMUM_INPUT = 10;
    const int MINIMAL_MULTIPLICATION = 1;
    const int MAXIMUM_MULTIPLICATION = 10;

    bool result = false;

    while (!result)
    {
        if (number >= MINIMUM_INPUT && number <= MAXIMUM_INPUT)
        {
            for (int i = MINIMAL_MULTIPLICATION; i <= MAXIMUM_MULTIPLICATION; i++)
            {
                Console.WriteLine($"{number} * {i} = {number * i}");
                result = true;
            }
        }
        else
        {
            Console.Write("Enter a number from 1 to 10. Try again.\nNumber: ");
            number = Convert.ToInt32(Console.ReadLine());
        }
    }
    
    #endregion

    
    #region Task 8
    
    Console.Write("Enter and check if the number is prime or complex (0 exit from the program).\nNumber: ");
    int number = Convert.ToInt32(Console.ReadLine());

    while (true)
    {
        const int MAXIMUM_NUMBER_OF_DIVISORS = 2;
        const int STARTING_COUNTDOWN = 1;
    
        int numberOfDivisors = 0;
    
        if (number == 0)
        {
            Console.Write("You have completed the program.");
            break;
        }
    
        for (int i = STARTING_COUNTDOWN; i <= number; i++)
        {
            if (number % i == 0)
            {
                numberOfDivisors++;
            }
        }

        Console.Write(numberOfDivisors == MAXIMUM_NUMBER_OF_DIVISORS
            ? $"The number {number} is prime, try again.\nNumber: "
            : $"The number {number} is composite, try again.\nNumber: ");

        number = Convert.ToInt32(Console.ReadLine());
    }

    #endregion
}