using System;

class MainClass {
  public static void Main (string[] args) {
    if (DateTime.Now.Hour < 11)
    {
      Console.WriteLine("time to breakfast");
    }
    else if (DateTime.Now.Hour < 15)
      {
        Console.WriteLine("time to lunch");
      }
    else
      {
        Console.WriteLine("time to supper");
      }
    }
  }