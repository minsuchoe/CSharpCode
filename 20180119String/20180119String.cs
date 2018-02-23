using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine(String.Format("{0,10:0.0}", 123.4567));
    
    string s = "ABCDEF";
    Console.WriteLine(s.IndexOf("CDE"));
    
    s = "1000,2000,3000";
    string[] prices = s.Split(',');
    foreach(string price in prices)
    Console.WriteLine(price);
    
    s = "1000, 2000, 3000";
    prices = s.Replace(" ", "").Split(',');
    foreach(string price in prices)
    Console.WriteLine(price);
  
    s = "ABCDEF";
    Console.WriteLine(s.Substring(1, 4));
  }
}