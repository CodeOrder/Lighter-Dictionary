using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace LighterDictionary
{
	public class DicIO
	{
		public static void SaveDic()
		{
			File.Delete ("Dic");
			FileStream DicFile = new FileStream ("Dic",FileMode.Create);
			StreamWriter writer = new StreamWriter (DicFile);
			foreach (string eng in Diclib.Dicbody.Keys) 
				writer.WriteLine (eng + ":" + Diclib.Dicbody [eng]);	//ENG:CHS
			writer.Close ();
			writer.Dispose ();
		}
		public static void LoadDic()
		{
            string[] lines = File.ReadAllLines("Dic");
            foreach(string line in lines)
                Diclib.Dicbody.Add(line.Split(':')[0], line.Split(':')[1]);
		}
	}
}

