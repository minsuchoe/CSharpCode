using System;

class MainClass {
  public static void Main (string[] args) {
    string[] subjects = {"Korean", "English", "Math"};
    int[] scores = new int[3];
    
    Console.Write(subjects[0]);
    Console.WriteLine(" : check your scores");
    scores[0] = int.Parse(Console.ReadLine());
    
    Console.Write(subjects[1]);
    Console.WriteLine(" : check your scores");
    scores[1] = int.Parse(Console.ReadLine());
    
    Console.Write(subjects[2]);
    Console.WriteLine(" : check your scores");
    scores[2] = int.Parse(Console.ReadLine());
  }
}