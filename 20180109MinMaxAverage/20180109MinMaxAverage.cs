using System;

class MainClass {
  public static void Main (string[] args) {
    int[] score = new int[20] {80,74,81,90,34,84,76,95,45,66,74,82,76,57,51,88,73,98,51,60};
    
    // MAX
    int max = score[0];
    for (int i = 0; i < score.Length; i++) {
      if (max < score[i])
        max = score[i];
    }
    Console.WriteLine ("max : " + max);
    
    
    // MIN
    int min = score[0];
    for (int i = 0; i < score.Length; i++) {
      if (min > score[i])
        min = score[i];
    }
    Console.WriteLine ("min : " + min);
    
    
    // AVERAGE
    double total = 0;
    
    for (int i = 0 ; i < score.Length; i++) {
      total += score[i];
    }
    
    Console.WriteLine("total : " + total);
    
    double average = total / score.Length;
    
    Console.WriteLine("avarage : " + average);
    
  }
}