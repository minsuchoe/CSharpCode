using System;

class MainClass {
  public static void Main (string[] args) {
    int s = 0, i = 0;
    
    do
    {
      ++i;
      s += i;
    } while (i < 10);
    
    Console.WriteLine("all sum from 1 to " + i + " is " + s);
  }
}