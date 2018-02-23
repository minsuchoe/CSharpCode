using System;
using System.Collections;
using System.Collections.Generic;

public static string Stringify<T> (this IEnumerable<T> list) {
  string s = String.Empty;
  foreach(var v in list) {
    s += v.ToString() + " ";
  }
  if (s.Length > 0)
    s = s.Substring(0, s.Length-1);
    return s;
}

class MainClass {
  public static string Stringify(int[] list) {
    string s = String.Empty;
    for(int i = 0; i < list.Length; i++)
      s += i != list.Length-1 ? list[i] + " " : list[i].ToString();
      return s;
  }
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
  }
}