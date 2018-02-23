//숙제 : (전화번호, user)로 hashtable 만들기
using System;
using System.Collections;

class User {
  public string Name {get; set;}
  public int Age {get; set;}
  public User(string name, int age) {
    Name = name;
    Age = age;
  }
}

class MainClass {
  public static void Main (string[] args) {
    
  // User[] users = new User[4] { new User("Betty", 23), 
  //                               new User("Susan", 20),
  //                               new User("Lisa", 25),
  //                               new User("Rob", 26) };    
    
    Hashtable ht = new Hashtable();
    
    
    ht.Add("1234", new User("Betty", 23));
    ht.Add("5678", new User("Susan", 20));
    ht.Add("9123", new User("Lisa", 25));
    ht.Add("4567", new User("Rob", 26));
    
    Console.WriteLine(ht.Count == 4);
    
    try
    {
      ht.Add("4567", "Paul");
    }
    catch
    {
      Console.WriteLine("The Key = \"4567\" already exists.");
    }
    Console.WriteLine(ht.Count == 4);
    
    ht["8912"] = "Tom";
    Console.WriteLine(ht.Count == 5);
  }
}