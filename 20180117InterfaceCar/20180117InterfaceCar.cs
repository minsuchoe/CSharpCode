using System;

interface IEquatable {
  bool Equals(Car car);
}

interface ICloneable {
  Car Clone();
}

interface IStringify {
  string Stringify();
}

class Car : IEquatable, ICloneable, IStringify {
  
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
  
  public string Stringify() {
    return Make + ", " + Model + ", " + Year;
  }
  
}

class MainClass {
  public static void Main (string[] args) {
    Car car = new Car();
    car.Make = "BMW";
    Console.WriteLine(car.Make);
    car.Model = "Mini";
    car.Year = "2017";
    
    Car car2 = new Car();
    car2.Make = "Tesla";
    car2.Model = "X";
    car2.Year = "2018";
    
    Console.WriteLine(car != car2);
    Console.WriteLine(car.Equals(car2) != true);
    
    Car cloneCar = car.Clone();
    Console.WriteLine(cloneCar.Equals(car) == true);
    cloneCar.Make = "Honda";
    Console.WriteLine(car.Make == "BMW");
    
    Console.WriteLine(car.Stringify() == "BMW, Mini, 2017");
  }
}