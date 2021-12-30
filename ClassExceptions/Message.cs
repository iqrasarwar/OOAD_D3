using System;
using System.Collections.Generic;
using MsgAPI;

namespace message
{
	class Message
	{
		//possible exceptions that can occur in the following methods. Refer to their code to  see how they can occur.

		Message()
        {
			System.IO.IOException;
			System.InvalidCastException;
		}
		public void NewMessage()
        {
			System.IO.IOException;
		}
		public void MakeDraft()
        {
			System.IO.IOException;
		}
		public void SendMessage(string Content, string Receipent)
        {
			System.ArgumentException;
			System.ArgumentNullException;
			System.ArgumentOutOfRangeException; 
			System.MethodAccessException;
			System.AccessViolationException;
			System.UnauthorizedAccessException;
		}
		public void ReceiveMessage(string MsgId)
        {
			System.ArgumentException;
			System.ArgumentNullException;
			System.ArgumentOutOfRangeException; 
			System.MethodAccessException;
			System.AccessViolationException;
			System.UnauthorizedAccessException;
		}
		public void DiscardDraft(string MsgId)
        {
			System.ArgumentException;
			System.ArgumentNullException;
			System.ArgumentOutOfRangeException; 
			System.IndexOutOfRangeException;
		}
		public void DeleteMsg(string MsgId)
        {
			System.ArgumentException;
			System.ArgumentNullException;
			System.ArgumentOutOfRangeException; 
			System.IndexOutOfRangeException;
		}
		public void ReportMsg(string MsgId)
        {
			System.ArgumentException;
			System.ArgumentNullException;
			System.ArgumentOutOfRangeException; 
			System.IO.IOException;
			System.MethodAccessException;
			System.AccessViolationException;
			System.UnauthorizedAccessException;
		}
	};
}

