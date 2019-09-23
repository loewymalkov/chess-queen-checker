using System;
using System.Collections.Generic;

class Queen {

  static void Main(){
    Console.WriteLine("Enter your postion for x");
    double inputX = int.Parse(Console.ReadLine());

    Console.WriteLine("Enter your postion for y");
    double inputY = int.Parse(Console.ReadLine());

   
    double slope = (inputY - 1)/(inputX - 1);

    if (slope == 1|| slope == 0 || slope == -1 || inputX == 1)
    {
      Console.WriteLine("true");
    }
    else
    {
      Console.WriteLine("false");
    }

  }  
}