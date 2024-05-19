using System;

class Program
{
    static void Main()
    {
        int number = 7;
        SumOfEvenNumbers(number);
    }

    static void SumOfEvenNumbers(int n)
    {
        int sum = 0;
        for (int i = 0; i <= n; i += 2)
        {
            sum += i;
        }
        Console.WriteLine(sum);
    }
}
