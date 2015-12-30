// A Hello World! program in C#.
using System;
namespace HelloWorld
{
  class Hello
  {
    /// <summary>
    ///   The main entry point for the application
    /// </summary>
    [STAThread]
    public static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      //Keep the Console window open in debug mode.
      Console.WriteLine("Press any key to exit");
      Console.ReadKey();

    }

  }

}
