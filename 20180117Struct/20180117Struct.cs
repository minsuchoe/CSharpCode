using System;
class Cake {
  public string name;
  public int price;
}

struct Cake2 {
  public string name;
  public int price;
}

class MainClass {
  public static void Main (string[] args) {
    Cake cake = new Cake();
    cake.name = "Blueberry";
    cake.price = 30000;
    
    Cake b;
    b = cake;
    b.price = 100;
    Console.WriteLine(cake.price == 100);
    
    Cake2 cake2 = new Cake2();
    cake2.price = 12000;
    Console.WriteLine(cake2.price == 12000);
    
    Cake2 c;
    c = cake2;
    c.price = 300;
    Console.WriteLine(cake2.price == 300);
  }
}