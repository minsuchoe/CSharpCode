using System;

class MainClass
{
  public static int Frequency (int[] list, int a)
  {
    int count = 0;
    for (int i = 0; i < list.Length; i++) {
      if (list[i] == a) {
        count += 1;
      }
    }
    return count;
  }
  
  public static void Main (string[] args) {
    int[] scores = new int [] {7, 5, 4, 3, 5, 5, 5, 4, 9, 5, 1, 3, 5, 7};
    // Console.WriteLine(Frequency(scores, 5));
    int result = Frequency(scores, 5);
    Console.WriteLine(result);
    Console.WriteLine(Frequency(scores, 5) == 6);
  }
}