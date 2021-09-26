using System;

class Program {
  public static void Main (string[] args) {
    
  for(int i=1; i<=10; i++)
  {
    Console.WriteLine("Enter a number");
    int num = Convert.ToInt32(Console.ReadLine());
    if (num % 2 != 0)
    {
      Console.WriteLine(num + " is prime");
      break;
    }
  }
  }
}