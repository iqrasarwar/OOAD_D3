using System;
using System.Collections.Generic;
using MeetAPI;

namespace meetings
{
	class Meetings
	{
		private DateTime dateTime { get; set; }
		private string Duration { get; set; }
		private string Receipent { get; set; }
		private List<string> Participant { get; set; }
		private static List<Meetings> scheduledMeets = new List<Meetings>();
		private string Topic { get; set; }
		private string MeetId { get; set; }

		Meetings()
		{
			static int id = 1;
			this.MeetId = Convert.ToString(id);
			id++;
			Topic = "";
			Receipent = "";
			Participant = new List<string>();
			Duration = "";
		}
		public void ScheduleNewMeeting()
        {
			Meetings meet;
			Console.WriteLine("Enter meeting time");
			dateTime = Convert.ToDateTime(Console.ReadLine());
			Console.WriteLine("enter the participants or 0 to exist");
			int end = 1;
			while(end != 0)
            {
				end = Console.ReadLine();
				if (end != "0")
					Participant.Add();
				else
					break;
            }
			Console.WriteLine("Enter meeting topic");
			Topic = Console.ReadLine();
			Console.WriteLine("Enter expected duration");
			Duration = Console.ReadLine();
			Console.WriteLine("Enter meet guest email");
			Receipent = Console.ReadLine();
			scheduledMeets.Add(meet);
		}
		public void AttendMeet(string MeetId)
        {
			foreach(Meetings m in scheduledMeets)
            {
				if (scheduledMeets[m].MeetId == MeetId)
				{
					if (scheduledMeets[m].dateTime == DateTime.now)
					{
						MeetAPI.intiateNew(scheduledMeets[m]);
					}
					else
					{
						Console.WriteLine("Meet isn't scheduled for this time");
					}
				}
            }
        }
		public void cancelMeet(string MeetId)
        {
			foreach (Meetings m in scheduledMeets)
			{
				if (scheduledMeets[m].MeetId == MeetId)
				{
					scheduledMeets.Remove(scheduledMeets[m]);
				}
			}
		}
		public void SendInvitation(List<string> Participants, string MeetId)
        {
			this.ScheduleNewMeeting();
			MeetAPI.initateInvites(this);
		}
	};
}
