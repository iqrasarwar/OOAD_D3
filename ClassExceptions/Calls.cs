using System;
using System.Collections.Generic;

namespace Calls
{
	class Calls
	{
		//possible exceptions that can occur in the following methods. Refer to their code to  see how they can occur.

		Calls()
        {
			System.InvalidCastException;
			System.ArithmeticException;
		}
		public void NewCall()
        {
			System.IndexOutOfRangeException;
			System.IO.IOException;
			System.MethodAccessException;
			System.AccessViolationException;
			System.UnauthorizedAccessException;
		}
		public void ReceiveCall(string caller)
        {
			System.ArgumentException;
			System.ArgumentNullException;
			System.ArgumentOutOfRangeException;
			System.IndexOutOfRangeException;
			System.IO.IOException;
			System.AccessViolationException;
			System.MethodAccessException;
			System.UnauthorizedAccessException;
		}
		public void AddNewCallToLog()
        {
			//No Exception Thrown
		}
		public void DeleteCallFromLog(string CallId)
        {
			System.IndexOutOfRangeException;
			System.ArgumentException;
			System.ArgumentNullException;
			System.ArgumentOutOfRangeException;
		}
		public void ClearLog()
        {
			//No Exception Thrown
        }
		public void BlockCaller(string Callid)
        {
			System.IndexOutOfRangeException;
			System.ArgumentException;
			System.ArgumentNullException;
			System.ArgumentOutOfRangeException;
		}
	};
}