using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("how many students are there?");
    int studentCount = int.Parse(Console.ReadLine());
    
    int[] ages = new int[studentCount];
    string[] names = new string[studentCount];
    double[] heights = new double[studentCount];
    
    int studentNumber = 0;
    
    while (studentNumber < studentCount) {
      Console.WriteLine("student no. " + studentNumber);
      
      Console.WriteLine("how old is he or she?");
      ages[studentNumber] = int.Parse(Console.ReadLine());
      
      Console.WriteLine("type he or she's name.");
      names[studentNumber] = Console.ReadLine();
      
      Console.WriteLine("how tall is he or she?");
      heights[studentNumber] = double.Parse(Console.ReadLine());
      
      studentNumber++;
    }
    
    studentNumber = 0;    // 다시 초기화
    
    while (studentNumber < studentCount)
    {
      Console.WriteLine("no. " + studentNumber);
      Console.WriteLine("name : " + names[studentNumber]);
      Console.WriteLine("age : " + ages[studentNumber]);
      Console.WriteLine("height : " + heights[studentNumber]);
      
      studentNumber++;
    }
  }
}