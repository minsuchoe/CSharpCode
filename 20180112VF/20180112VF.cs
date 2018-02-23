using System;

class MainClass {
  public static int Frequency (int[] list, int a) {
    int count = 0;
    for (int i = 0; i < list.Length; i++) {
      if (a == list[i]) {
        count++;
      }
    }
    return count;
  }
  public static int ValueOfFrequency (int[] list)
  {
    int maxValue = 0;
    int maxCount = 0;
    
    for (int i = 0; i < list.Length; i++) {
      int count = Frequency(list, list[i]);
      if (count > maxCount)
      {
        maxCount = count;
        maxValue = list[i];
      }
    }
    return maxValue;
  }
  public static void Main (string[] args) {
    int[] scores = new int[] {1,1,2,2,2,3,3,3,3,4,4,4};
    Console.WriteLine(Frequency(scores, 3));
    Console.WriteLine(ValueOfFrequency(scores));
  }
}