using System;

class Cat
{
  public string Name;
  public string Color;
  
  public void Meow()
  {
    Console.WriteLine("{0} : Meow", Name);
  }
}

class MainClass
{
  public static void Main (string[] args)
  {
    Cat tonky = new Cat();
    tonky.Color = "Cheese";
    tonky.Name = "Tonky";
    tonky.Meow();
    Console.WriteLine("{0}, {1}", tonky.Name, tonky.Color);
  
    Cat minky = new Cat();
    minky.Color = "White";
    minky.Name = "Minky";
    minky.Meow();
    Console.WriteLine("{0}, {1}", minky.Name, minky.Color);
  }
}