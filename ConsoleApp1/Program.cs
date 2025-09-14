using System;  // <-- must be first

class MainProgram
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bismillah hir rahmanir rahim");
        Helper.SayHello();
        ApiCalling.Call("Md Merazul Islam", 22);
        // ApiCalling.Call("Md Merazul Islam", 22); // will print full name
        int a, b, c;
        a = 1;
        b = 2;
        c = a + b;
       double   sqt = Math.Sqrt(c);
        Console.WriteLine(c);
        Console.WriteLine(Math.Round(sqt, 2));
        string firstName = "John ";
        string lastName = "Doe";
        string name = string.Concat(firstName, lastName);
        Console.WriteLine(name);

        IfElse.CompareNumbers(1, 2, 3);

    }
}
