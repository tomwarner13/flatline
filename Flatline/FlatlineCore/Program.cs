using System;
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
        ExecuteCommand (args [0]); //todo: find out how to get all but the first value of an array
      }
		}

		private static void ExecuteCommand(string command, params string[] args)
		{
			switch (command) 
			{
			case "build":
				//build project
				break;
			case "rebuild":
				//rebuild project
				break;
			case "help":
				//show help
				break;
			default:
				Console.WriteLine($"Command {command} not recognized. Type 'help' for help.");
				break;
			}
		}
	}
}
