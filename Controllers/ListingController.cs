using System; 
using System.Threading;
using Burgershack2.Services; 

namespace Burgershack2.Controller 
{
public class EntreeController 
{
    public EntreeController(EntreeService _entreeService) 
        {
          this._entreeService = _entreeService;
               
        }
          private EntreeService _entreeService {get; set;} = new EntreeService(); 
public void UserInput()
{
  _entreeService.GetEntrees(); 
  print(); 
  string Choice = Console.ReadLine().ToLower(); 
  Console.clear(); 
  switch (Choice) 
{
  case "q": 
  Environment.Exit(1); 
  break, 
  default: 
  if(int.tryparse(Choice, out int index)); 
  {
    _entreeService.GetEntrees(index -1);
    print(); 
    Console.readKey();
    Console.Clear(); 
    
  }
}

}
}
}