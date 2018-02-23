using System;

class Cat
{
  public string name;
  public string owner;
  public int id;
  public string bio;
  public enum cattributes {Granitegrey, Royalpurple, Orangesoda, Topaz, Crazy, Jaguar, Beard};
  public string children;
  
  public cattributes[] ca;
  public Cat[] child;
  
}

class MainClass
{
  public static void Main (string[] args)
  {
    Cat kitty = new Cat();
    kitty.name = "Kitty";
    kitty.owner = "Wilson";
    kitty.id = 2;
    kitty.bio = "Hello! I'm Kitty the Cat!!";
    kitty.ca = new Cat.cattributes[7];
    kitty.ca[0] = Cat.cattributes.Topaz;
    kitty.ca[1] = Cat.cattributes.Jaguar;
    
    kitty.child = new Cat[10];
    kitty.child[0] = new Cat();
    kitty.child[0].name = "Genesis";
    
    
    Console.WriteLine(kitty.name);
    Console.WriteLine(kitty.owner);
    Console.WriteLine(kitty.id);
    Console.WriteLine(kitty.bio);
    Console.WriteLine(kitty.ca[0]);
    Console.WriteLine(kitty.child[0].name);
    
  }
}