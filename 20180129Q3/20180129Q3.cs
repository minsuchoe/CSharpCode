using System;

class MainClass {
  public static void Main (string[] args) {
    
    int[] array = {2,1,4,5,6,3};
    
    Console.WriteLine(array.Min() == 1);
    Console.WriteLine(array.Max() == 6);
    Console.WriteLine(array.First() == 2);
    Console.WriteLine(array.Last() == 3);
    Console.WriteLine(array.Sum() == 2+1+4+5+6+3);
    Console.WriteLine(array.Average() == array.Sum()/array.Length);
  }
}

public static class Exclass {
  
  public static int First(this int[] list) {
    return list[0];
  }
  
  public static int Last(this int[] list) {
    return list[list.Length - 1];
  }
  
  public static int Min(this int[] list) {
    int min = list[0];
    for (int i = 0; i <list.Length; i++) {
      if (list[i] < min)
        min = list[i];
    }
    return min;
  }
  
  public static int Max(this int[] list) {
    int max = list[0];
    for (int i = 0; i <list.Length; i++) {
      if (list[i] > max)
        max = list[i];
    }
    return max;
  }
  
  public static int Sum(this int[] list) {
    int total = 0;
    for (int i = 0; i < list.Length; i++) {
      total += list[i];
    }
    return total;
  }
  
  public static double Average(this int[] list) {
    int total = 0;
    for (int i = 0; i < list.Length; i++) {
      total += list[i];
    }
    double average = total / list.Length;
    return average;
  }
  
  
}