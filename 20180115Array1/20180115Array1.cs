using System;

class MainClass {
  
  enum Animal {mouse, cat, bird, dog=100, koala, pig=200, lion};
  
  public static void Main (string[] args) {
    Animal a;
    a= Animal.dog;
    
    Console.WriteLine (Animal.cat);
    Console.WriteLine ((int)Animal.dog);
    Console.WriteLine ((int)Animal.lion);
    Console.WriteLine (a);
  }
}