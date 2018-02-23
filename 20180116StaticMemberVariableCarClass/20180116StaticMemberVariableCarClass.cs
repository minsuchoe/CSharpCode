using System;

class Car {
  public string name;
  public static int count = 0; //public int count;
  
  public Car (string name) {
    this.name = name;
    count++;
  }
}

class MainClass {
  public static void Main (string[] args) {
    //Car aCar = new Car("BMW M5");
    //aCar.count = 2;
    
    Console.WriteLine (Car.count == 0);
    
    new Car("BMW M5");  //Car a = new Car("BMW M5");
    new Car("MINI");   //Car b = new Car("MINI");
    
    Console.WriteLine(Car.count);
    Console.WriteLine(Car.count == 2);
  }
}