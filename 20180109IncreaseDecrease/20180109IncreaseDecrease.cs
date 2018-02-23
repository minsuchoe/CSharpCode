using System;

class MainClass {
  public static void Main (string[] args) {
    int a = 10;
    Console.WriteLine(a++);
    Console.WriteLine(++a);
    
    int b = 10;
    Console.WriteLine(b--);
    Console.WriteLine(--b);
  }
}