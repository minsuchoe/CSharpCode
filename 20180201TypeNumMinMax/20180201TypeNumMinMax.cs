using System;

class MainClass {
  public static void Main (string[] args) {
    int[] array = new int[5];
    
    for (int i = 0; i < 5; i++) {
      Console.Write("Type any no. : ");
      array[i] = int.Parse(Console.ReadLine());
    }
    Console.WriteLine("--- --- --- --- ---");
    
    int min = array[0];
    for (int i = 0; i < array.Length; i++)  {
      if (min > array[i])
        min = array[i];
    }
    Console.WriteLine("min : " + min);
    
    int max = array[0];
    for (int i = 0; i < array.Length; i++)  {
      if (max < array[i])
        max = array[i];
    }
    Console.WriteLine("max : " + max);
    
  }
}