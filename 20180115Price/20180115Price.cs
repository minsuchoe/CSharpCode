using System;

class Book {
  public string title;
  public int    price;
  public string author;

  public Book(string title, int price, string author) {
    this.title = title;
    this.author = author;
    this.price = price;
  }

  public float GetSalePrice(float sale) {
    float sprice = this.price - this.price * sale;
    return sprice;
  }

}

class MainClass {


  public static void Main (string[] args) {
    Book lor = new Book("The Lord of the Ring", 30000, "J. R. R. Tolkien");
    Book hobbit = new Book("Hobbit", 20000, "J. R. R. Tolkien");
    
    Book[] books = new Book[2];
    books[0] = lor;
    books[1] = hobbit;
    
    for (int i = 0; i < books.Length; i++) {
      Console.WriteLine(books[i].title + ": " + books[i].GetSalePrice(0.1f));
    }
  }
}

