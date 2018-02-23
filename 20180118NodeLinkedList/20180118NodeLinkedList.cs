using System;

class Node {    // make node
  public string data;
  public Node next;
  // public Node previous;
}

class LinkedList {
  
  Node head;
  Node tail;
  
  public int Count { get; private set; }
  
  public LinkedList() {
    head = tail = null;
    Count = 0;
  }
  
  public void AddFirst (string obj) {
    Node newNode = new Node();
    newNode.data = obj;
    newNode.next = null;
 
    if (head == null) {
      head = tail = newNode;
    } else {
      newNode.next = head;
      head = newNode;
    }
    Count++;
  }
  
  public void AddLast (string obj) {
    Node newNode = new Node();
    newNode.data = obj;
    newNode.next = null;
    
    if (head == null) {
      head = newNode;
    } else {
      tail.next = newNode;    //붙이다
    }
    
    tail = newNode;   //꼬리를 바꾸다
    Count++;
  }
  
  public string RemoveFirst() {
    
    if (head == null) {
      return string.Empty;   // return "Empty";
    } else {
      string s = head.data;
      head = head.next;
      Count--;
      return s;
    }
  }
  
  public string Stringify()  {
    Node current = head;
    string s = "";
    while(current != null) {
      s += current.data;
      current = current.next;
    }
    return s;
  }
}

class MainClass {
  public static void Main (string[] args) {
    
    LinkedList list = new LinkedList();
    
    Console.WriteLine(list.Count == 0);
    list.AddLast("one");
    Console.WriteLine(list.Count == 1);
    list.AddLast("two");
    Console.WriteLine(list.Count == 2);
    Console.WriteLine(list.Stringify() == "onetwo");
    list.AddLast("three");
    Console.WriteLine(list.Stringify() == "onetwothree");
    Console.WriteLine(list.Count == 3);
    
    list.AddFirst("four");
    Console.WriteLine(list.Count == 4);
    Console.WriteLine(list.Stringify() == "fouronetwothree");
    
    Console.WriteLine(list.RemoveFirst() == "four");
    Console.WriteLine(list.Count == 3);

    Console.WriteLine(list.Stringify() == "onetwothree");
    
    Console.WriteLine(list.RemoveFirst() == "one");
    Console.WriteLine(list.Count == 2);
    Console.WriteLine(list.Stringify() == "twothree");
    
  }
}