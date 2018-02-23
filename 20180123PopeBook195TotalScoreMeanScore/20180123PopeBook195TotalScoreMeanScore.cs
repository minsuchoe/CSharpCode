using System;

class MainClass {
  public static void Main (string[] args) {
    string[] subjects = {"Korean", "English", "Math", "Science", "Social"};
    int[] scores = new int[5];
    
    Console.Write(subjects[0] + " score : ");
    scores[0] = int.Parse(Console.ReadLine());
    Console.Write(subjects[1] + " score : ");
    scores[1] = int.Parse(Console.ReadLine());
    Console.Write(subjects[2] + " score : ");
    scores[2] = int.Parse(Console.ReadLine());
    Console.Write(subjects[3] + " score : ");
    scores[3] = int.Parse(Console.ReadLine());
    Console.Write(subjects[4] + " score : ");
    scores[4] = int.Parse(Console.ReadLine());
    
    int totalScore = scores[0] + scores[1] + scores[2] + scores[3] + scores[4];
    int meanScore = totalScore / subjects.Length;
    
    Console.WriteLine("Your total score is : " + totalScore);
    Console.WriteLine("Your mean score is : " + meanScore);
  }
}