//ValueOfMaxFreq()의 내부 구현을 Dictionary<>를 이용하도록 변경하기

using System;
using System.Collections.Generic;

class MainClass {
  public static int Frequency (int[] list, int a) {
    int count = 0;
    for (int i = 0; i < list.Length; i++) {
      if (list[i] == a) {
        count += 1;
      }
    }
    return count;
  }

  public static int ValueOfMaxFrequency (int[] list) {
    Dictionary<int, int> dic = new Dictionary<int, int>();
    
    for (int i = 0; i < list.Length; i++) {
      if ( dic.ContainsKey(list[i]) ) {
        // int v = dic[list[i]];
        // dic[list[i]] = v + 1;
        dic[ list[i] ] += 1;
      } else {
        dic[ list[i] ] = 1; // dic.Add(list[i], 1);
      }
    }
      
      int maxKey = 0;
      int maxValue = 0;
      
      foreach (var v in dic)
        if (v.Value > maxValue) {
          maxKey = v.Key;
          maxValue = v.Value;
        }
        
    return maxKey;
  }
  
  // public static int ValueOfMaxFrequency (int[] list) {
  //   int maxCount = 0;
  //   int maxValue = 0;
    
  //   for (int i = 0; i < list.Length; i++) {
  //     int count = Frequency(list, list[i]);
  //     if (count > maxCount) {
  //       maxCount = count;
  //       maxValue = list[i];
  //     }
  //   }
  //   return maxValue;
  // }
  
  public static void Main (string[] args) {
    int[] scores = new int[] {5, 6, 7, 5, 6, 7, 8, 8, 8, 8, 9, 1};

    Console.WriteLine(ValueOfMaxFrequency(scores) == 8);
  }
}