using System;

class Animal {
  public Animal() {
    Console.WriteLine("Animal"); }
}
class Mammal : Animal {
  public Mammal() {
    Console.WriteLine("Mammal"); }
}
class Cat : Mammal {
  public Cat() {
  Console.WriteLine("Cat"); }
}

class MainClass {
  public static void Main (string[] args) {
    Cat cat = new Cat();
  }
}