using System;

class MainClass {
  public static void Main (string[] args) {
    
    int[] list = new int[9] {9, 8, 4, 5, 3, 2, 1, 6, 7};
    
    int indexMin, tmp;
    
    for (int i = 0; i < list.Length - 1; i++)
    {
      indexMin = i;
      for (int j = i + 1; j < list.Length; j++)
      {
        if (list[j] < list[indexMin])
        {
          indexMin = j;
        }
      }
      tmp = list[indexMin];
      list[indexMin] = list[i];
      list[i] = tmp;
      
    for (int k = 0; k < list.Length; k++)
    {
      Console.Write(list[k]);
    }
      Console.WriteLine();
    }
  }
}