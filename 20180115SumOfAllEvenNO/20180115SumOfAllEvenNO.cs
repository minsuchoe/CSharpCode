using System;

class MainClass {
  public static void Main (string[] args) {
    
    int s = 0;
    
    for (int i = 0; i <=100; i++)
    {
      if (i % 2 == 0)
      {
        s += i;
      }
    }
    Console.Write("Sum of all even numbers from 1 to 100 is " + s);
  }
}