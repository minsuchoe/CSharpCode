using System;

class MainClass {
  public static void Main (string[] args) {
    int a = 3;
    int b = 4;
    bool result;
    
    result = a < b && b < 5;
    Console.WriteLine(result);
    
    result = a > b && b < 5;
    Console.WriteLine(result);
    
    result = a > b || b < 5;
    Console.WriteLine(result);
    
    result = !result;
    Console.WriteLine(result);
    
    
  }
}