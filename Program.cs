using System;
using burgershack2.Controller;
using burgershack2.Services;

namespace burgershack2
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();
      var service = new EntreeService();
      EntreeController menu = new EntreeController(service);
      while (true)
      {
        menu.UserInput();
      }

    }
  }
}
