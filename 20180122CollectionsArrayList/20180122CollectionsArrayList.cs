using System;
using System.Collections;

class MainClass {
  public static void Main (string[] args) {
    ArrayList list = new ArrayList();
    list.Add(100);
    Console.WriteLine((int)list[0] == 100);
    list.Add(200);
    Console.WriteLine((int)list[1] == 200);
    Console.WriteLine(list.Count == 2);
    
    list.Insert(2, 300);
    Console.WriteLine((int)list[2] == 300);
    
    list.Remove(100);
    Console.WriteLine(list.Count == 2);
    Console.WriteLine((int)list[0] == 200);
    Console.WriteLine((int)list[1] == 300);
    
    Console.WriteLine(list.Contains(200) == true);
    Console.WriteLine(list.Contains(700) == false);    
    
  }
}