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
  
  public static int ValueOfMaxFrequency (int[] list)
  {
    int maxCount = 0;
    int maxValue = 0;
    for (int i = 0; i < list.Length; i++)
    {
      int count = Frequency(list, list[i]);
      if (count > maxCount)
      {
        maxCount = count;
        maxValue = list[i];
      }
    }
    return maxValue;
  }
  public static void Main (string[] args)
  {
    int[] scores = new int[] {5, 6, 7, 5, 6, 7, 8, 8, 8, 8, 9, 1};
    int result = ValueOfMaxFrequency(scores);
    Console.WriteLine(result);
    Console.WriteLine(result == 8);
    
  }
}