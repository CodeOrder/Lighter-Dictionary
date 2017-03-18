using System;
using System.Collections.Generic;

namespace LighterDictionary
{
	public class Diclib
	{
		public static Dictionary<string,string> Dicbody = new Dictionary<string,string>();
		public static void Addword(string eng,string chs)
		{
            Dicbody.Add(eng.ToLower(), chs);                    //Make sure that ever thing is lower
			DicIO.SaveDic ();
		}
		public static void Delword(string eng)
		{
			Dicbody.Remove (eng.ToLower());                     //Make sure that ever thing is lower
			DicIO.SaveDic ();
		}
		public static void Showord(string eng)
		{
            //DicIO.LoadDic ();
			Console.WriteLine ("\t\t\t" + eng + " : " + Dicbody [eng]);
		}
	}
}

