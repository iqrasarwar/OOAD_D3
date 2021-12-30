using System;
using System.Collections.Generic;
using MeetAPI;

namespace meetings
{
	class Meetings
	{
		private DateTime dateTime;
		private string Duration;
		private string Receipent;
		private List<string> Participant;
		private static List<Meetings> scheduledMeets = new List<Meetings>();
		private string Topic;
		private string MeetId;

		Meetings();
		public void ScheduleNewMeeting();
		public void AttendMeet(string MeetId);
		public void cancelMeet(string MeetId);
		public void SendInvitation(List<string> Participants, string MeetId);
	};
}
