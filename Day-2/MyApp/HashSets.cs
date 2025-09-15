using System;
using System.Collections.Generic;

class HashSets
{
  public static void RunHash(string[] args)
  {
    HashSet<int> unq = new HashSet<int> { 1, 2, 3, 4, 4, 5, 6, 2 };

    Console.WriteLine("Number of unique elements: " + unq.Count);

    foreach (int num in unq)
    {
      Console.Write(num + " ");
    }

  }
}