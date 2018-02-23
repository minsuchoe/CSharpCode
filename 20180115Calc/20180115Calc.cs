using System;

class Calc {
  public int add (int a, int b) {
    return a+b;
  }
}

class Caculation {
  static void disp () {
    int c;
    Calc calc = new Calc();
    c = calc.add(8,2);
    Console.WriteLine("8 + 2 = " + c);
  }
  
  static void Main() {
    disp();
  }
}