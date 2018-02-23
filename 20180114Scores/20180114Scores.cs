using System;

class MainClass {
  public static void Main (string[] args) {
    string[] names = {"Hong", "Kim", "Choi", "Lee", "Kwon", "Jang"};
    
    int[] scores = {48,75,62,90,84,28};
    
    int i, j;
    string s;
    for (i = 0; i < 6; i++)
    {
      Console.Write(names[i] + " " + scores[i] + " ");
      for (j = 0; j < scores[i] / 5; j++)
      {
        Console.Write("*");
      }
      if (scores[i] < 50)
      s = "need more effort";
      else if (scores[i] < 70)
      s = "normal";
      else if (scores[i] < 90)
      s = "well done";
      else
      s = "perfect!";
      Console.WriteLine(" "+s);
    }
  }
}