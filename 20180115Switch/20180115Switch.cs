using System;

class MainClass {
  public static void Main (string[] args) {
    
    for (int a = 5; a <= 8; a++)
    {
      Console.Write(a + " / 3 = " + a/3);
    
      switch (a % 3)
      {
        case 1:
        Console.WriteLine(" : reminder is 1");
        break;
      
        case 2:
        Console.WriteLine(" : reminder is 2");
        break;
      
        default:
        Console.WriteLine(" : reminder is 0");
        break;
      }
    }
  }
}