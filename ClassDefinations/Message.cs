using System;
using System.Collections.Generic;
using MsgAPI;

namespace message
{
	class Message
	{
		private readonly DateTime dateTime = DateTime.Now;
		private string Content;
		private string Receipent;
		private string MsgId;
		private static list<Message> drafts = new list<Message>();
		private static list<Message> sent = new list<Message>();
		private static list<Message> received = new list<Message>();

		Message();
		public void NewMessage();
		public void MakeDraft();
		public void SendMessage(string Content, string Receipent);
		public void ReceiveMessage(string MsgId);
		public void DiscardDraft(string MsgId);
		public void DeleteMsg(string MsgId);
		public void ReportMsg(string MsgId);
	};
}

