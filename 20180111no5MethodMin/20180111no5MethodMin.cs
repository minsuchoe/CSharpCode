using System;

class MainClass
{
  public static int Min (int[] list)
  {
    int min = list[0];
    for (int i = 0; i < list.Length; i++)
    {
      if (min > list[i])
      {
        min = list[i];
      }
    }
    return min;
  }
  public static void Main (string[] args) {
    int[] scores = new int[] {15, 43, 67, 89, 29};
    int result = Min(scores);
    Console.WriteLine(result);
  }
}