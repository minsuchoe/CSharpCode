using System;

class MainClass {
  public static void Main (string[] args) {
    string[] names = {"a", "b", "c", "d"};
    int[] scores = {48, 75, 62, 88};
    string s;
    
    for (int i = 0; i < 4; i++)
    {
      Console.Write(names[i] + " " + scores[i] + " ");
      for (int j = 0; j < scores[i]/5; j++)
      {
        Console.Write("*");
      }
      if (scores[i] < 60)
      {
        s = "have to study hard";
      } else if (scores[i] < 70)
      {
        s = "need more effort";
      } else if (scores[i] < 80)
      {
        s = "well done";
      }
      else
        s = "good job";
      Console.WriteLine(" " + s);
    }
    
    
  }
}