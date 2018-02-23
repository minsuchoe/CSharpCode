using System;
using System.Collections.Generic;
using System.Linq;

public class student {
  public string Name {get; set;}
  public int Height {get; set;}
  public List<int> Scores {get; set;}
  
  public override string ToString() {return Name;}
}

class MainClass {
  public static void Main (string[] args) {
    List<Student> list = new List<Student> {
      new student() {Name = "ctkim", Height = 175, Scores = new List<int>() {100,70,90,77,88}},
      new student() {Name = "Steve", Height = 165, Scores = new List<int>() {100,60,90,77,55}},
      new student() {Name = "Brown", Height = 175, Scores = new List<int>() {30,61,91,100,57}},
      new student() {Name = "Won", Height = 175, Scores = new List<int>() {100,100,91,100,100}},
      new student() {Name = "JJ", Height = 165, Scores = new List<int>() {10,100,9,100,100}}
    };
    
    Console.WriteLine(list.Stringify() == "ctkim Steve Brown Won JJ");
    
    
    int[] numbers = {1,2,3,4,5,6,7,8,9,10};
    var evens = from n in numbers
                where n % 2 == 10
                select n;
        Console.WriteLine(evens.Stringify() == "2 4 6 8 10");
        
    var ss6 = from student in list
              where student.Height < 175
              orderby student.Height
              select new {Name=student.Name, InchHeight = student.Height * 0.393};
    foreach (var s in ss6)
      Console.WriteLine(s.Name + " " + s.InchHeight);
    Console.WriteLine();
  }
}