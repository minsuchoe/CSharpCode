using System;

class MainClass {
  
  public static void Main (string[] args) {
    int a;
    int b;
    float f = 0.001f;
    char c = 'c';
    string str = "string";
    string str2 = "string2";
    bool bo = true;
    const int mapSizeX = 100;
    
    a = 2;
    b = 3;
    
    int temp;
    temp = a;
    a = b;
    b = temp;
    
    /*
    {
      float a;
      float b;
      float c;
    }
    */
    
    // mapSizeX = 100;
    
    {
      int k = 0;
      Console.WriteLine(k);
    }
    
    // ctrl + /
    // Console.WriteLine(k);
    
    Console.WriteLine ("a = " + a);
    Console.WriteLine ("f = " + f);
    Console.WriteLine ("c = " + c);
    Console.WriteLine ("str = " + str);
    Console.WriteLine (str + str2);
    Console.WriteLine (bo);
    
    Console.WriteLine ("Hello World");
  }
}