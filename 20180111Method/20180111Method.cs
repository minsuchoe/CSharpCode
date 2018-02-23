using System;

class MainClass {
  public static int Plus (int a, int b)
  {
    int result = a + b;
    return result;
  }
  public static void Main (string[] args)
  {
    int x = 3;
    int y = 4;
    int result = Plus(x, y);
    Console.Write(result);
  }
}