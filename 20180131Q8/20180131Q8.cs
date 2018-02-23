// 두개의 이미 정렬된 int[] 주어졌을 때 하나로 합쳐주는 MergeArrays(int[] A, int[] B) 함수를 작성하라.
// 함수의 결과물은 int[]이다.
// 이미 정렬되었다는 이점을 이용해서 즉 소팅 함수를 사용하지 않고 작성해야 한다.

using System;

class MainClass {
  public static string Stringify(int[] list) {
    string s = String.Empty;
    
    for (int i = 0; i < list.Length; i++) {
      s += (i != list.Length - 1) ? list[i].ToString() + " " : list[i].ToString();
    }
    return s;
  }
  
  public static int[] MergeArrays (int[] A, int[] B) {
    
    int[] list = new int[A.Length + B.Length];
    Console.WriteLine(list.Length);
    
    int indexA = 0;
    int indexB = 0;
    
      for (int i = 0; i < list.Length; i++) {
        if (indexA == A.Length) {
          list[i] = B[indexB];    //list[i] = A[indexA++];
          indexB++;
          continue;
        }
        
        if (indexB == B.Length) {
          list[i] = A[indexA];    //list[i] = B[indexB++];
          indexA++;
          continue;
        }
        
        if (A[indexA] < B[indexB]) {
          list[i] = A[indexA];    //list[i] = A[indexA++];
          indexA++;
        } else {
          list[i] = B[indexB];    //list[i] = B[indexB++];
          indexB++;
        }
      }
      
    return list;
    
  }
  
  public static void Main (string[] args) {
    
    int[] A = {1,2,3,4,5};
    int[] B = {4,5,6,7};
    
    Console.WriteLine(Stringify(MergeArrays(A, B)) == "1 2 3 4 4 5 5 6 7");
  }
}