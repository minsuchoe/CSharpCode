using System;


class Book {
  public string title;
  public string author;
  public int    price;
  
  public Book(string title, string author, int price) {
    this.title = title;
    this.author = author;
    this.price = price;
  }
  
  /*
  public Book(string _title, string _author, int _price) {
    title = _title;
    author = _author;
    price = _price;
  }
  */
}
class MainClass {
  public static void Main (string[] args) {
    Book lor;
    lor = new Book("The Lord of the Rings", "J. R. R. Tolkien", 50000);
    
    Console.WriteLine(lor.title);
    
    
    Book hobbit;
    hobbit = new Book("Hobbit", "J. R. R. Tolkien", 40000);
    Console.WriteLine(hobbit.title);
  }
}
