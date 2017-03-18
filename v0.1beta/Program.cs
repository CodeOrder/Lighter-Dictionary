using System;

namespace LighterDictionary
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			DicIO.LoadDic ();
			Console.WriteLine ("***************************************");
			Console.WriteLine ("*         Lighter Dictionary          *");
			Console.WriteLine ("*      Produce by Code Order 2017     *");
			Console.WriteLine ("*             v 0.1 beta              *");
			Console.WriteLine ("***************************************");
			while (true) 
			{
				try
				{
					Console.WriteLine ("Wait for command");
					switch (Console.ReadLine ()) {
					case "@":
						string[] temp = Console.ReadLine ().Split (':');
						Diclib.Addword (temp [0].ToLower(), temp [1]);
						break;
					case "#":
						Diclib.Showord (Console.ReadLine ().ToLower());
						break;
					case "!":
						Diclib.Delword(Console.ReadLine());
						break;
					case "$$":
                            
						break;
					case "h":
						Console.WriteLine("*** Commands ***");
						Console.WriteLine("@ + Enter + English:Chinese (Add)");
						Console.WriteLine("# + Enter + English (Show)");
						break;

					}
				}catch(Exception ex){
					Console.WriteLine (ex.Message);
				}
			}
		}
	}
}
