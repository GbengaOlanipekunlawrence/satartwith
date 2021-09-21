using System;
class FirstLetterChecker
{
  static void Main()
  {
    Console.WriteLine("the aphabet you enter contain Z");
    string ifAphabetCZ = Console.ReadLine();
    if (ifAphabetCZ.StartWith("Z"))
    {
      Console.WriteLine("the letter you write contains Z");
    }
    else
    {
      Console.WriteLine("the letter you write do not contain Z");
    }
  }
}
