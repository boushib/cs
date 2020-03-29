using System;

namespace console
{
  class Program
  {
    static void Main(string[] args)
    {
      //   string[] games = {"League", "Dota 2", "Clash Royale", "Apex Legends", "Fortnite"};
      //   foreach(string game in games)
      //   {
      //     Console.WriteLine(game);
      //   }
      void sayHello(string name)
      {
        System.Console.WriteLine($"Hello {name}!");
      }
      System.Console.WriteLine("What's your name?");
      System.Console.Write("-> ");
      string name = System.Console.ReadLine();
      sayHello(name);
    }
  }
}
