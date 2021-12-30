using System;
using System.Collections.Generic;
using CallingAPI;

namespace Calls
{
	class Calls
	{
		private readonly DateTime dateTime = DateTime.Now;
		private string Duration { get; set; }
		private string SNumber { get; set; }
		private string Receipent { get; set; }
		private string Callid { get; set; }
		private static List<Calls> Log = new List<Calls>();
		private static List<string> blocked = new List<string>();
		DateTime dateTime { get; }

		Calls()
		{
			Duration = "";
			SNumber = "03xx xxxxxxx";
			Receipent = "";
			Callid = "";
			static int id = 1;
			this.Callid = Convert.ToString(id);
			id++;
		}
		public void NewCall()
		{
			Console.WriteLine("enter Contact Number");
			Receipent = Console.ReadLine();
			foreach (string s in blocked)
			{
				if (Receipent == s)
				{
					Console.Write("Can't make call to blocked contact");
					return;
				}
			}
			this.AddNewCallToLog();
			CallingAPI.intiateNew(SNumber, Receipent);
		}
		public void ReceiveCall(string caller)
		{
			foreach (string s in blocked)
			{
				if (caller == s)
				{
					return;
				}
			}
			this.AddNewCallToLog();
			callingAPI.initiateNew(caller, SNumber);
		}
		public void AddNewCallToLog()
		{
			Log.Add(this);
		}
		public void DeleteCallFromLog(string CallId)
		{
			foreach (Calls call in Log)
			{
				if (Log[call].Callid == CallId)
				{
					Log.Remove(Log[call]);
				}
			}
		}
		public void ClearLog()
		{
			Log.Clear();
		}
		public void BlockCaller(string Callid)
		{
			foreach (Calls call in Log)
			{
				if (Log[call].Callid == CallId)
				{
					string receient = Log[call].Receipent;
					blocked.Add(receient);
				}
			}
		}
	};
}