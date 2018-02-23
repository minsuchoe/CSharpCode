using System;
using System.Threading;

class MainClass {
  public static void Main (string[] args) {
    int i = 1;
    
    while (i < 50) {
      Console.Clear();
      Console.SetCursorPosition(i, 5);
      
      if (i % 3 == 0)
        Console.WriteLine("__@");
      else if (i % 3 == 1)
        Console.WriteLine("_^@");
      else
        Console.WriteLine("^_@");
      
      Thread.Sleep(100);
      i++;
    }
  }
}