using System;
using System.Threading;
using System.Threading.Tasks;

class MainClass {
  public static void Main (string[] args) {
    
    Task<string> task = new Task<string> ( () => {
      Thread.Sleep(100);
      Console.WriteLine("in Task : " + Thread.CurrentThread.ManagedThreadId);
      return "Task result";
    } );
    task.Start();
    Console.WriteLine("in Main");
  
    Console.WriteLine(task.Result == "Task result");
    
    Task<string> task1 = new Task<string> ( () => {
      Thread.Sleep(100);
      Console.WriteLine("in Task : " + Thread.CurrentThread.ManagedThreadId);
      return "Task result";
    } );
    task1.Start();
    Console.WriteLine("in Main");
  
    Console.WriteLine(task1.Result == "Task result");
  }
}