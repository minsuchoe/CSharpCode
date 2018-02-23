using System;

class Wdata {
  public int month;
  public int day;
  public string sky;
  
}

class Weather {
  static void Main () {
    
    Wdata today = new Wdata ();
    today.month = 10;
    today.day = 9;
    today.sky="clear";
    
    Console.WriteLine (today.month + " month " + today.day + " day " + today.sky);
  }
}
