using System;



class Book {
  public string title;
  public string author;
  public string publisher;
  public int    price;
  
  public Book(string _title, string _author, int price) {
    title = _title;
    author = _author;
    price = _price;
  }
}

class MainClass {
  public static void Main (string[] args) {
    Book lor;
    lor = new Book();
    lor.title = "The Lord of the Rings";
    lor.author = "J. R. R. Tolkien";
    lor.publisher = "wikibooks";
    lor.price = 50000;
    
    Console.WriteLine(lor.title);
    Console.WriteLine(lor.author);
    Console.WriteLine(lor.publisher);
    Console.WriteLine(lor.price + "WON");
    
    Book hobbit;
    hobbit = new Book();
    hobbit.title = "Hobbit";
    hobbit.author = "J. R. R. Tolkien";
    
    Console.WriteLine(hobbit.title);
  }
}