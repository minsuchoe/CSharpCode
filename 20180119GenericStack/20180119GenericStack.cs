using System;

class Stack <T> {
  T [] data;   // make array
  int top;
  int size;
  
  public int Count;
  
  public Stack (int size) {
    data = new T [size];
    top = -1;
    this.size = size;
    Count = 0;
  }
  
  public void Push (T value) {
    if (top == size-1)
      return;
    top++;
    data[top] = value;
    Count++;
  }
  
  public T Pop () {
    if (top == -1)
      return default(T);
    T value = data[top];
    top--;
    Count--;
    return value;
  }
}

class MainClass {
  public static void Main (string[] args) {
    Stack<int> s = new Stack<int>(3);
    // Stack<string> s = new Stack<string>(3);
    Console.WriteLine(s.Count == 0);
    s.Push(10);
    Console.WriteLine(s.Count == 1);
    s.Push(20);
    Console.WriteLine(s.Count == 2);
    s.Push(30);
    Console.WriteLine(s.Count == 3);
    s.Push(40);
    Console.WriteLine(s.Count == 3);
    Console.WriteLine(s.Pop() == 30);
    Console.WriteLine(s.Pop() == 20);
    Console.WriteLine(s.Pop() == 10);
    Console.WriteLine(s.Count == 0);
    Console.WriteLine(s.Pop() == default(int));   //empty
    
    // s.Count = 10;
  }
}