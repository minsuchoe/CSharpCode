using System;
class Scope {
  int zoom = 1;
  public void printZoom() {
    int zoom = 2;
    
    Console.WriteLine(zoom + ", " + this.zoom);
  }
}
class MainClass {
  public static void Main (string[] args) {
    Scope sc = new Scope();
    sc.printZoom();
  }
}