using System;

class MainClass {
  public static void Main (string[] args) {
    
    float p1 = 4;
    float p2 = 12;
    float q1 = 1;
    float q2 = 3;
    
    if (p1 > p2 || q1 > q2)
    {
     Console.WriteLine("Inpur Error!") ;
     return;
    }
    
    if (p2 < q1 || q2 < p1)
    {
      Console.WriteLine("not overlapped");
    }
    else
    {
      Console.WriteLine("overlapped");
    }
    
    if (p1 < q1)
    {
      if (p2 < q1) {
        Console.WriteLine("not overlapped");
      }
      else {
        Console.WriteLine("overlapped");
      }
    }
    else
    {
      if (p1 > q2) {
        Console.WriteLine("not overlapped");
      }
      else {
        Console.WriteLine("overlapped");
      }
    }
  }
}