using System;
using System.Threading;
using burgershack2.Services;

namespace burgershack2.Controller
{
  public class EntreeController
  {
    public EntreeController(EntreeService entreeService)
    {
      _entreeService = entreeService;
    }
    private EntreeService _entreeService { get; set; } = new EntreeService();
    public void UserInput()
    {
      _entreeService.GetEntree();
      Print();
      string Choice = Console.ReadLine().ToLower();
      Console.Clear();
      switch (Choice)
      {
        case "q":
          Environment.Exit(1);
          break;
        default:
          if (int.TryParse(Choice, out int index))
          {
            _entreeService.GetEntree(index - 1);
            Print();
            Console.ReadKey();
            Console.Clear();
          }
          else
          {
            System.Console.WriteLine("Invalid Command");
          }
          break;
      }
    }
    void Print()
    {
      foreach (string message in _entreeService.Messages)
      {
        System.Console.WriteLine(message);
      }
      _entreeService.Messages.Clear();
      System.Console.WriteLine();
    }
  }
}