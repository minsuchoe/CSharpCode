using System;

class MainClass {
  public static void Main (string[] args) {
    int userInput = int.Parse(Console.ReadLine());
    
    if (userInput > 20 || (userInput % 3 == 0)) {
      Console.WriteLine("you have typed more than 20 and 3 multiple.");
    }
    else
      Console.WriteLine("you have not typed more than 20 and 3 multiple.");
  }
}