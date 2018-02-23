using System;

class MainClass
{
  public static void Main (string[] args)
  {
    Console.Write("type numbers : ");
    int input = int.Parse(Console.ReadLine());
    
    if (input % 2 == 0)
    {
      Console.WriteLine("even");
    }
    
    // if (input % 2 == 1)
    else
    {
      Console.WriteLine("odd");
    }
    
    Console.WriteLine(DateTime.Now.Hour + " : " + DateTime.Now.Minute);
    
    if (DateTime.Now.Hour < 12)
    {
      Console.WriteLine("Ante meridiem");
    }
    // if (12 <= DateTime.Now.Hour)
    else
    {
      Console.WriteLine("Post meridiem");
    }
  }
}