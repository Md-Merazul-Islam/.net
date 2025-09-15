using System;
using System.Collections.Generic;

class Queues
{
  public static void RunQue(string[] args)
  {
    Queue<int> que = new Queue<int>();

    que.Enqueue(1);
    que.Enqueue(2);
    que.Enqueue(3);
    que.Enqueue(4);
    que.Enqueue(5);
    que.Enqueue(6);
    que.Enqueue(7);
    que.Enqueue(8);
    que.Enqueue(9);
    que.Enqueue(10);
    que.Enqueue(11);
    while (que.Count > 0)
    {
      Console.WriteLine(que.Dequeue());
    }
    Console.WriteLine(que.Count);
  }
}