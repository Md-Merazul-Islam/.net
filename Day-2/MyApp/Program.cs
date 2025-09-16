using System;
using System.Collections.Generic;
using System.Threading.Tasks;

class Program
{
  static async Task Main(string[] args)
  {
    // int[] a = { 1, 2, 3, 4, 5 };
    // for (int i = 0; i < a.Length; i++)
    // {
    //   Console.Write(a[i] + " ");
    // }
    // Console.WriteLine();

    // TryParseUse.Run(args);
    // Dictionarys.RunDict(args);
    // HashSets.RunHash(args);
    // Queues.RunQue(args);
    Stacks.RunStack(args);
    var result = await GetDataAsync();
    Console.WriteLine(result);
  }
  static async Task<string> GetDataAsync()
  {
    await Task.Delay(2000); // ২ সেকেন্ড delay
    return "Data Loaded!";
  }

}