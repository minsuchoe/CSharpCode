using System;

public static class Exclass {
  
  public static string Stringify(this int[] list) {
    
    string s = String.Empty;
    for (int i = 0; i < list.Length; i++)
      s += i != list.Length - 1 ? list[i] + " " : list[i].ToString();
      return s;
      
  }
}

class MainClass {
  
  public static string Stringify(int[] list) {
    
    string s = String.Empty;
    for (int i = 0; i < list.Length; i++)
      s += i != list.Length - 1 ? list[i] + " " : list[i].ToString();
      return s;
  }
  
  public static void Main (string[] args) {
    
    int[] arrayA = new int[] {8, 3, 2};
    
    Console.WriteLine(Stringify(arrayA) == "8 3 2"); // 아래의 메소드 호출
    
    Console.WriteLine(arrayA.Stringify() == "8 3 2"); // 위의 확장된 클래스 호출
  }
}