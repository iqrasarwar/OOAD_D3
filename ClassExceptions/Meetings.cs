using System;
using System.Collections.Generic;
using MeetAPI;

namespace meetings
{
	class Meetings
	{
		//possible exceptions that can occur in the following methods. Refer to their code to  see how they can occur.

		Meetings()
        {
			System.InvalidCastException;
			System.ArithmeticException;
		}
		public void ScheduleNewMeeting()
        {
			System.IO.IOException;
		}
		public void AttendMeet(string MeetId)
        {
			System.ArgumentException;
			System.ArgumentNullException;
			System.ArgumentOutOfRangeException; 
			System.IO.IOException;
			System.IndexOutOfRangeException;
		}
		public void cancelMeet(string MeetId)
        {
			System.ArgumentException;
			System.ArgumentNullException;
			System.ArgumentOutOfRangeException; 
			System.IndexOutOfRangeException;
		}
		public void SendInvitation(List<string> Participants, string MeetId)
        {
			System.ArgumentException;
			System.ArgumentNullException;
			System.ArgumentOutOfRangeException; 
			System.IndexOutOfRangeException;
			System.MethodAccessException;
			System.AccessViolationException;
			System.UnauthorizedAccessException;
		}
	};
}
