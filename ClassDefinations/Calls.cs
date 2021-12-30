using System;
using System.Collections.Generic;

namespace Calls
{
	class Calls
	{
		private readonly DateTime dateTime = DateTime.Now;
		private string Duration;
		private string SNumber;
		private string Receipent;
		private string Callid;
		private static List<Calls> Log = new List<Calls>();
		private static List<string> blocked = new List<string>();

		Calls();
		public void NewCall();
		public void ReceiveCall(string caller);
		public void AddNewCallToLog();
		public void DeleteCallFromLog(string CallId);
		public void ClearLog();
		public void BlockCaller(string Callid);
	};
}