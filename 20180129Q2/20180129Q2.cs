using System;

class Book {
  public string Title {get; set;}
  public int Price    {get; set;}
}
  
class MainClass {
  
  public static string Stringify(int[] list) {
    string s = String.Empty;
    
    for (int i = 0; i < list.Length; i++)
      s += i != list.Length - 1 ? list[i] + " " : list[i].ToString();
    
    return s;
  }
  
  public static void Swap(ref int x, ref int y) {
    int temp = x;
    x = y;
    y = temp;
  }
  
  public static bool Swap(int[] arrayA, int[] arrayB) {
    if ( arrayA.Length == arrayB.Length && arrayA.Length > 0 ) {
      for( int i = 0; i < arrayA.Length; i++ ){
        int temp = arrayA[i];
        arrayA[i] = arrayB[i];
        arrayB[i] = temp;
      }
      return true;
    } else
    return false;
  }

  public static void Swap(Book a, Book b) {
   string tempTitle = a.Title;
   a.Title = b.Title;
   b.Title = tempTitle;
   
   int tempPrice = a.Price;
   a.Price = b.Price;
   b.Price = tempPrice;
  }

  public static void SwapMinMax(int[] list) {
    int minIndex, maxIndex;
    
  }
  
  public static void Main (string[] args) {
    int a = 10, b = 20;
    Swap(ref a , ref b);
    Console.WriteLine(a == 20 && b == 10);
    
    int[] arrayA = {1,2,3,4};
    int[] arrayB = {5,6,7,8};
    Console.WriteLine( Swap(arrayA, arrayB) == true );
    Console.WriteLine(Stringify(arrayA) == "5 6 7 8");
    
    arrayA = new int[] {1,2,3,4};
    arrayB = new int[] {5,6,7,8,9};
    Console.WriteLine( Swap(arrayA, arrayB) == false );
    Console.WriteLine((Stringify(arrayA) == "5 6 7 8") == false);    

    Book b1 = new Book() { Title = "book1", Price = 10000 };
    Book b2 = new Book() { Title = "book2", Price = 20000 };
    Swap(b1, b2);
    Console.WriteLine(b1.Title == "book2" && b1.Price == 20000);
    Console.WriteLine(b2.Title == "book1" && b2.Price == 10000);
    
    int[] minMax = {9,8,7,6,5,4,3};
    SwapMinMax(minMax);
    Console.WriteLine(Stringify(minMax) == "3 8 7 6 5 4 9");
    
  }
}