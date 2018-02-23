using System;

class MainClass {
  public static void Main (string[] args) {
    
    for (int i = 0; i < 5; i++) {
      for (int j = 0; j < i + 1; j++) {
          Console.Write("*");
        }
        Console.WriteLine();
    }
    for (int k = 3; k >= 0; k--) {
      for (int a = 0; a < k + 1; a++) {
        Console.Write("*");
        }
        Console.WriteLine();
    }
    }
  }
