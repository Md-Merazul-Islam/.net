using System;
using System.Collections.Generic;

class TryParseUse
{
  public static void Run(string[] args)
  {
    //List 
    Console.Write("Enter a number of n: ");
    // int n = Convert.ToInt32(Console.ReadLine());
    int n;
    while (!int.TryParse(Console.ReadLine(), out n))
    {
      Console.WriteLine("Invalid input. Please enter a valid number.");
    }

    List<int> nums = new List<int>(n);

    for (int i = 0; i < n; i++)
    {
      // nums.Add(Convert.ToInt32(Console.ReadLine()));
      int num;
      while (!int.TryParse(Console.ReadLine(), out  num))
      {
        Console.WriteLine("Invalid input. Please enter a valid number.");
      }
      nums.Add(num);
    }

    foreach (int num in nums)
    {
      Console.Write(num + " ");
    }
  }
}