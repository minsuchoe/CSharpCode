using System;

class MainClass {
  public static void Main (string[] args) {
    int[] score = new int[10] {1,2,3,4,5,6,7,8,9,10};
    
    int total = 0;
    
    for (int i = 0; i < score.Length; i++) {
      total += score[i];
    }
    
    Console.WriteLine("total : " + total);
    
    double average = (float)total / score.Length;
    
    Console.WriteLine("average : " + average);
    
    
  }
}