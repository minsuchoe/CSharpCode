using System;

class MainClass {
  
  public static string FizzBuzz (int i) {
    
    if (i % 3 == 0 && i % 5 == 0)   //if (i % 15 == 0)
      return "FizzBuzz";
    else if (i % 3 == 0)
      return "Fizz";
    else if (i % 5 == 0)
      return "Buzz";
    
    return String.Empty;
  }
  
  public static void Main (string[] args) {
    
    Console.WriteLine(FizzBuzz(2) == String.Empty);
    Console.WriteLine(FizzBuzz(3) == "Fizz");
    Console.WriteLine(FizzBuzz(5) == "Buzz");
    Console.WriteLine(FizzBuzz(15) == "FizzBuzz");
    
    for(int i = 1; i <= 100; i++)
      Console.WriteLine(i + " : " + FizzBuzz(i));
    
    // Console.Write("Type your No. : ");
    // int i = int.Parse(Console.ReadLine());
    
    // if (i <= 0) {
    //   Console.WriteLine("do NOT type negative no. or zero.");
    // } else if (i % 3 == 0) {
    //   Console.WriteLine("Fizz");
    // } else if (i % 5 == 0) {
    //   Console.WriteLine("Buzz");
    // } else if (i % 3 == 0 && i % 5 == 0) {
    //   Console.WriteLine("FizzBuzz");
    // } else {
    //   Console.WriteLine("you have to type 3 or 5 multiple no.");
    // }
    
    // for (int j = 1; j < 101; j++;) {
      
    // }
    
    // Console.WriteLine((i % 3 == 0) == "Fizz");
    // Console.WriteLine((i % 5 == 0) == "Buzz");
    // Console.WriteLine((i % 3 && i % 5 == 0) == "FizzBuzz");
    
    
  }
}