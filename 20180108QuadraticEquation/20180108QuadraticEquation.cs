using System;

class MainClass {
  public static void Main (string[] args) {
    double a = 1.0;
    double b = 3.0;
    double c = 1.0;
    
    double D = 0;
    
    D = b * b - 4.0 * a * c;
    
    double sol;
    if (D == 0) {
      sol = (-b + Math.Sqrt(D) ) / (2 * a);
      Console.WriteLine ("1");
      
      if (a * sol * sol + b * sol + c == 0) {
        Console.WriteLine("OK");
      }
      
    } else if (D > 0) {
      sol = (-b + Math.Sqrt(D) ) / (2 * a);
      double sol2 = (-b - Math.Sqrt(D) ) / (2 * a);
        Console.WriteLine ("+/-");
    } else {
        Console.WriteLine ("None");
    }
  
    }
}