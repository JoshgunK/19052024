using System;

class Program
{
    static void Main()
    {
        int number = 5;
        int sumOfEvenNumbers = SumOfEvenNumbers(number);
        Console.WriteLine(sumOfEvenNumbers);
    }

    static int SumOfEvenNumbers(int n)
    {
        int sum = 0;
        for (int i = 0; i <= n; i += 2)
        {
            sum += i;
        }
        return sum;
    }
}
