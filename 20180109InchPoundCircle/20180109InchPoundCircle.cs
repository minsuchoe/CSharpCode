using System;

class MainClass {
  public static void Main (string[] args) {

// cm to inch
    Console.Write("type you want to change cm into inch : ");
    string input1 = Console.ReadLine();
    Console.WriteLine(input1 + "cm");
    double inch = double.Parse(input1) * 2.54;
    Console.WriteLine(input1 + "cm is " + inch + "inch");

    
// kg to pound
    Console.Write("type you want to change kg into pound : ");
    string input2 = Console.ReadLine();
    Console.WriteLine(input2 + "kg");
    double lbs = double.Parse(input2) * 2.20462262;
    Console.WriteLine(input2 + "kg is " + lbs + "lbs");
    
// circle round and width
    Console.Write("radius? : ");
    string input3 = Console.ReadLine();
    Console.WriteLine(input3);
    double round = 2 * Math.PI * double.Parse(input3);
    Console.WriteLine("circle round is : " + round);
    
    double width = Math.PI * double.Parse(input3) * double.Parse(input3);
    Console.WriteLine("circle width is : " + width);
  }
}