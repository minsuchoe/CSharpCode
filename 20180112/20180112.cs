using System;

class MainClass {
  public static int sum(int num)
  {
    if (num < 2)
    return num;
    return num + sum(num-1);
  }
  public static void Main (string[] args)
  {
    int num = 100;
    Console.WriteLine(sum(num));
  }
}