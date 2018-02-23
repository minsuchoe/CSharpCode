using System;

class MainClass {
  public static void Main (string[] args) {
    int[] scores = new int[5];
    int count = 0;
    
    while (count < scores.Length) {
      // Console.WriteLine("Type " + count + "subject's score");
      // scores[count] = int.Parse(Console.ReadLine());
      // count++;
      Console.WriteLine("Type 1st subject's score");
      scores[0] = int.Parse(Console.ReadLine());
      count++;
      Console.WriteLine("Type 2nd subject's score");
      scores[1] = int.Parse(Console.ReadLine());
      count++;
      Console.WriteLine("Type 3rd subject's score");
      scores[2] = int.Parse(Console.ReadLine());
      count++;
      Console.WriteLine("Type 4th subject's score");
      scores[3] = int.Parse(Console.ReadLine());
      count++;
      Console.WriteLine("Type 5th subject's score");
      scores[4] = int.Parse(Console.ReadLine());
      count++;
    }
      Console.Write("\nSum of all scores is : " + (scores[0] + scores[1] + scores[2] +scores[3] +scores[4]));
  }
}