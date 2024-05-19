using System;

class Program
{
    static void Main()
    {
        string text = "Code          Academy";
        string result = Remove(text);
        Console.WriteLine(result);
    }
    static string Remove(string input)
    {
        string result = "";
        foreach (char c in input)
        {
            if (c != ' ')
            {
                result += c;
            }
        }
        return result;
    }
}
