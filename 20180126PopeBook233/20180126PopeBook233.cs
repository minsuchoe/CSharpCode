using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("How many classes do you take?");
    int subjectCount = int.Parse(Console.ReadLine());
    
    int[] scores = new int[subjectCount];
    int index = 0;
    int total = 0;
    
    while (index < subjectCount) {
      Console.WriteLine(index + "'s score?");
      scores[index] = int.Parse(Console.ReadLine());
      total = total + scores[index];
      index++;
    }
    
    double average = (double)total / index;
    Console.Write("average grade is " + average);
  }
}