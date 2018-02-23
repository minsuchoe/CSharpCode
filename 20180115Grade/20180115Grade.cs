using System;

class MainClass {
  public static void Main (string[] args) {

    int data = 55;

    if (data > 90)
    {
      Console.WriteLine("A");
    }
    else if (90 > data && data > 80)
    {
      Console.WriteLine("B");
    }
    else if (80 > data && data > 70)
    {
      Console.WriteLine("C");
    }
    else if (70 > data && data > 60)
    {
      Console.WriteLine("D");
    }
    else
    {
      Console.WriteLine("F");
    }
  }
}