using System;

class MainClass {
  public static void Main (string[] args) {
    int[] arr = new int[] {8,5,4,2,1,6,8,4,65,841,3,4};
    
    int l = arr.Length;
    int t;
    for (int i = 0; i < l/2; i++)
    {
      t = arr[i];
      arr[i] = arr[l-i-1];
      arr[l-i-1]=t;
    }
    Console.WriteLine("Reverse Complete");
  }
}