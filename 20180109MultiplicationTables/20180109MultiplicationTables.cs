using System;

class MainClass {
  public static void Main (string[] args) {
    
    for (int i = 1; i < 10; i++)     {
      for (int j = 1; j < 5; j++) {
        // Console.Write(j + "X" + i + "=" + i*j + "\t ");
        Console.Write("{0} X {1} = {2} \t", j, i, j*i);
      }
      Console.WriteLine();
    }
  }
}