using System;

class IfElse
{
    public static void CompareNumbers(int a, int b, int c)
    {
        if (a == b && b == c)
        {
            Console.WriteLine("All values are equal");
        }
        else if (a > b && a > c)
        {
            Console.WriteLine("A is greater");
        }
        else if (b > a && b > c)
        {
            Console.WriteLine("B is greater");
        }
        else
        {
            Console.WriteLine("C is greater");
        }
    }
}
