using System;

class MainClass {
  public static void Main (string[] args) {
   
    int[] myPos = {20, 30}; //my position
    int[ , ] enemyPos =     //enemy position
    {   
      {2,4},
      {10,6},
      {25,20}
    };
    
    int i;
    int dx, dy;
    double d;
    double r = 15; //range
    
    for (i=0; i<3; i++)
    {
      dx = myPos[0] - enemyPos[i,0];
      dy = myPos[1] - enemyPos[i,1];
      d = (double) dx * dx + dy * dy;
      
      if (d>r*r)
      {
        Console.WriteLine("enemy " + i + " is out of the range");
      }
      else
      {
        Console.WriteLine("enemy " + i + " is within the range");
      }
    }
  }
}