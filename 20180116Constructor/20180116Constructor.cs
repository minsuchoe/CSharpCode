using System;

class MainClass {
  class Book {
    public string title;
    public Book (string title) {
      this.title = title;
      Console.WriteLine("Book ctor");
    }
  }
  
  class Novel : Book {
    public string writer;
    public Novel (string title, string writer) : base(title) {
      this.writer = writer;
      Console.WriteLine("Novel ctor");
    }
  }
  
  class SFNovel : Novel {
    public SFNovel(string title, string writer) : base(title, writer) {
      Console.WriteLine("SFNovel ctor");
    }
  }
  public static void Main (string[] args) {
    SFNovel sf = new SFNovel("Hobbit", "Tolkien");
    Console.WriteLine(sf.title == "Hobbit");
    Console.WriteLine(sf.writer == "Tolkien");
  }
}