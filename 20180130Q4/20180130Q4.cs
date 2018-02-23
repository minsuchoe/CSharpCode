// 주어진 문자열에서 중복되는 문자를 제거해서 돌려주는 RemoveDuplicateChars(string str) 만들기

using System;

class MainClass {
  
  public static int IndexOf(string str, char c) {
    for(int i = 0; i < str.Length; i++) {
      if (str[i] == c)
        return i;
    }
    return -1;
  }
  
  public static string RemoveDuplicateChars(string str) {
    string uniqueString = String.Empty;

    for(int i = 0; i < str.Length; i++) {
      if (IndexOf(uniqueString, str[i]) == -1)    //배열에 없는 문자는 -1로 표시된다.
        uniqueString += str[i];
    // foreach (char c in str) {
    //     if (uniqueString.IndexOf(c) == -1)
    //       uniqueString += c;
    // }
    
    }

    return uniqueString;
  }
  
  public static void Main (string[] args) {
    
    // char[] array = {'a','b','c','d','a','b','e'};    // string str = "abcdabe";
    
    Console.WriteLine(IndexOf("ab", 'c') == -1);
    Console.WriteLine(IndexOf("bcd", 'd') == 2);
    Console.WriteLine(RemoveDuplicateChars("abcdabe") == "abcde");
  }
}


