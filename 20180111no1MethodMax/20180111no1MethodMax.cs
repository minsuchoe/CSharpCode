using System;

class MainClass {
  public static int Max (int a, int b)
  {
    if (a < b)
     {
       return b;
     }
     else
     {
       return a;
     }
  }
  public static void Main (string[] args)
  {
    int x = 2;
    int y = 9;
    Console.WriteLine(Max(x, y));
  }
}