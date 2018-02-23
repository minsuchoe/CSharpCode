using System;

class MainClass {
  public static void Divide (int a, int b, out int quotient, out int remainder) {
    quotient = a/b;
    remainder = a%b;
  }
  public static void Main (string[] args) {
    int x = 3;
    int y = 4;
    int quotient, remainder;
    
    Divide(x, y, out quotient, out remainder);
    
    Console.Write("{0},{1}", quotient, remainder);
  }
}