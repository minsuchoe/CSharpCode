using System;

class MainClass {
  public static void Main (string[] args) {
    for (int i = 0; i < 10; i++) {
      for (int j = 0; j < 10 - i; j++) {
        Console.Write(" ");
      }
      for (int j = 0; j < i + 1; j++) {
        Console.Write("*");
      }
      Console.WriteLine();
    }
  }
}