using System;
using System.Linq;
using System.Collections.Generic;

namespace FlatlineCore
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			if (args.Length == 0) 
      {
        ExecuteCommand ("help");
			}
      else
      {
        ExecuteCommand(args[0], args.Skip(1)); //todo: find out how to get all but the first value of an array
      }
		}

    private static void ExecuteCommand(string command, IEnumerable<string> args = null)
		{
			switch (command) 
			{
  			case "build":        
          Console.WriteLine ($"building project with args: {string.Join(" ", args)}");
  				break;
        case "rebuild":
          Console.WriteLine ($"rebuilding project with args: {string.Join(" ", args)}");
  				break;
        case "help":
          Console.WriteLine($"Heaven helps those who help themselves.");
  				break;
  			default:
  				Console.WriteLine($"Command '{command}' not recognized. Type 'help' for help.");
  				break;
			}
		}
	}
}
