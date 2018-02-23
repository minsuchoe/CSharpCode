using System;

class MainClass
{
  public static bool IsIn (int[] list, int a)
  {
    for (int i = 0; i < list.Length; i++) {
      if (list[i] == a)
        return true;
    }
    return false;
  }
  public static void Main (string[] args)
  {
    int[] scores = new int [] {1, 2, 3, 4, 5};    
    bool result = IsIn(scores, 3);
    Console.Write(result);
  }
}