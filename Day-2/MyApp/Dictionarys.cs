using System;
using System.Collections.Generic;

class Dictionarys
{
  public static void RunDict(string[] args)
  {

    Dictionary<string, int> dict = new Dictionary<string, int>();
    dict.Add("one", 1);
    dict.Add("two", 2);
    dict.Add("three", 3);
    dict.Add("four", 4);
    dict.Add("five", 5);
    foreach (KeyValuePair<string, int> kv in dict)
    {
      string key = kv.Key;
      int value = kv.Value;
      Console.WriteLine(kv.Key + " " + kv.Value);
    }
   

    foreach (string key in dict.Keys)
    {
      int value = dict[key];
      Console.WriteLine(key + " " + value);
    }


  }
}