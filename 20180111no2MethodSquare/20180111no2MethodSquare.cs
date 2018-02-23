using System;

class MainClass {
  public static int Power (int a, int r) {
    
    // 3^0 = 1;
    // 3^1 = 3;
    // 3^2 = 3 * 3;
    // 3^3 = 3 * 3 * 3;
    
    int s = 1;
    for (int i = 0; i < r; i++)
    {
      s = s * a;
    }
    return s;
  }
  
  public static void Main (string[] args) {
    
    int x = 3, y = 0;
    int result = Power(x, y);
    Console.Write(result);
  }
}