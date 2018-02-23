using System;

interface IEquatable {
  bool Equals(Car car);
}

interface IClonable {
  Car Clone();
}

interface IStringify {
  string Stringify();
}

class Cake {
  
}

class Car : IEquatable, IClonable {
  
  /*
  string make;
  public string Make {
    get {
      return make;
    }
    set {
      make = value;
    }
  }
  */
  
  public string Make {get; set;}
  public string Model {get; set;}
  public string Year {get; set;}
  
  public bool Equals (Car car) {
    if (Make == car.Make && Model == car.Model && Year == car.Year)
      return true;
    else
      return false;
  }
  public Car Clone() {
  Car cloneCar = new Car();
  cloneCar.Make = Make;       // this.Make;
  cloneCar.Model = Model;     // this.Model;
  cloneCar.Year = Year;       // this.Year;
  return cloneCar;
  }
  

  
}

class MainClass {
  public static void Main (string[] args) {
    Car car = new Car();
    car.Make = "BMW";
    Console.WriteLine(car.Make);
    car.Model = "Mini";
    car.Year = "2017";
    
    Console.WriteLine(car is int == false);
    Console.WriteLine(car is Cake == false);
    Console.WriteLine(car is Car == true);
    Console.WriteLine(car is IEquatable == true);
    Console.WriteLine(car is IClonable == true);
    Console.WriteLine(car is object == true);
    
    IClonable ic = car as IClonable;
    Console.WriteLine(ic != null);
    Console.WriteLine(ic.GetType().Name == "Car");
  }
}