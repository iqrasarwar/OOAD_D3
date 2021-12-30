using System;
using System.Collections.Generic;
using MsgAPI;

namespace message
{
	class Message
	{
		private readonly DateTime dateTime = DateTime.Now;
		private string Content { get; set; }
		private string Receipent { get; set; }
		private string MsgId { get; set; }
		private static list<Message> drafts = new list<Message>();
		private static list<Message> sent = new list<Message>();
		private static list<Message> received = new list<Message>();
		DateTime dateTime { get; }

		Message()
		{
			static int id = 1;
			this.MsgId = Convert.ToString(id);
			id++;
			Content = "";
			Receipent = "";
		}
		public void NewMessage()
        {
			Console.WriteLine("Enter message content");
			this.Content = Console.ReadLine();
			Console.WriteLine("Enter recepient username");
			this.Receipent = Console.ReadLine();
		}
		public void MakeDraft()
        {
			Message temp;
			Console.WriteLine("Enter message content");
			temp.Content = Console.ReadLine();
			Console.WriteLine("Enter recepient message");
			temp.Receipent = Console.ReadLine();
			drafts.Add(temp);
		}
		public void SendMessage(string Content, string Receipent)
        {
			NewMessage();
			MsgAPI.initiateNew(Receipent, Content);
			sent.Add(this);
		}
		public void ReceiveMessage(string MsgId)
        {
			NewMessage();
			MsgAPI.initiateNew(this.MsgId, Content);
			received.Add(this);
		}
		public void DiscardDraft(string MsgId)
        {
			foreach (Message m in drafts)
			{
				if (drafts[m].MsgId == MsgId)
				{
					drafts.Remove(drafts[m]);
				}
			}
		}
		public void DeleteMsg(string MsgId)
        {
			foreach (Message e in received)
			{
				if (received[e].MsgId == MsgId)
				{
					drafts.Remove(received[e]);
				}
			}
			foreach (Message e in sent)
			{
				if (sent[e].MsgId == MsgId)
				{
					drafts.Remove(sent[e]);
				}
			}
		}
		public void ReportMsg(string MsgId)
        {
			Console.WriteLine("Enter Complain");
			string complain = Console.ReadLine();
			MsgAPI.initiatReport(MsgId, complain);
		}
	};
}

