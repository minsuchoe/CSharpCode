using System;

class Kazu1 {
  int[] suji = new int[4];
  public int this[int i] {
    get {   return suji[i];    }
    set {   suji[i] = value;   }
  }
}

class Kazu2 {
  static void Main() {
    Kazu1 kz = new Kazu1();
    kz[0] = 1;
    kz[1] = 2;
    kz[2] = 3;
    kz[3] = 4;
    
    for (int i = 0; i <= 3; i++)
    {
      Console.WriteLine(kz[i]);
    }
  }
}

