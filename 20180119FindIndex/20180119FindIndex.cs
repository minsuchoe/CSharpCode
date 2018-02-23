using System;

delegate bool Condition(int i, int v);

class MainClass {
  static bool exist(int i, int v) {
   return v == 7;
  }
  static bool g(int i, int v) {
   return v > 3;
  }  
  // static bool exist2(int a, int b, int c) {
  // return b == 7;
  // }

  public static void Main (string[] args) {
    Condition c = exist;
    Console.WriteLine(c(0, 7) == true);
    // Condition d = exist2;
    
    
    int[] scores = new int[] {1, 2, 3, 5, 10, 7, 8};
    Console.WriteLine(FindIndex(scores, (i, v) => v == 7) == 5);
    Console.WriteLine(FindIndex(scores, exist) == 5);
    Console.WriteLine(FindIndex(scores, (i, v) => v == 100) == -1);
    Console.WriteLine(FindIndex(scores, (i, v) => v > 3) == 3);
    Console.WriteLine(FindIndex(scores, (i, v) => i > 5 && v > 3) == 6);
  }
  
  static int FindIndex(int[] list, Condition callback) {
    for (int i = 0; i < list.Length; i++) {
      if (callback(i, list[i]))
        return i;
    }
    return -1;
  }
}