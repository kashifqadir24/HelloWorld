using System;

// This Program takes in two numbers, and returns the sum of all of the numbers between and including those two numbers.
class NumbersSum
{
    public static void Main()
    {
        NumSum(5, 7);
    }

    public static void NumSum(int start, int end)
    {
        int sum = 0;
        for (int x = start; x <= end; x++)
            sum += x;
        Console.WriteLine("The sum of the integers between these two numbers is {0} ", sum);
    }
}