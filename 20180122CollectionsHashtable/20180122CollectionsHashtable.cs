using System;
using System.Collections;

class MainClass {
  public static void Main (string[] args) {
    Hashtable ht = new Hashtable();
    
    ht.Add("txt", "notepad.exe");
    ht.Add("bmp", "paint.exe");
    ht.Add("dib", "paint,exe");
    ht.Add("rtf", "wordpad.exe");
    Console.WriteLine(ht.Count == 4);
    
    try
    {
      ht.Add("txt", "winword.exe");
    }
    catch
    {
      Console.WriteLine("The Key = \"txt\" already exists.");
    }
    Console.WriteLine(ht.Count == 4);
    
    ht["max"] = "3dsmax.exe";
    Console.WriteLine(ht.Count == 5);
    
    Console.WriteLine(ht.ContainsKey("bmp") == true);
    
    ht.Remove("bmp");
    Console.WriteLine(ht.ContainsKey("bmp") == false);
    
    //숙제 : (전화번호, user)로 hashtable 만들기
    
    
  }
}