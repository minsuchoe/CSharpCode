using System;

class MainClass {
  public static void Main (string[] args) {
    int fiboTmp1 = 1, fiboTmp2 = 1, fibo = 1;
    
    int n = 20;
    
    if (n < 2)
    {
      fibo = 0;
    }
    
    else
    {
      for (int i = 2; i < n; i++)
      {
        fibo = fiboTmp1 + fiboTmp2;
        fiboTmp1 = fiboTmp2;
        fiboTmp2 = fibo;
      }
    }
    Console.WriteLine(fibo);
  }
}