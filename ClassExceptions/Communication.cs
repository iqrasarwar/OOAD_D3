using System;
using Email;
using Calls;
using BlogPosts;
using Meetings;

namespace communication
{
	public class Communication
	{
		//possible exceptions that can occur in the following methods. Refer to their code to  see how they can occur.

		private void CommunicateViaEmail(string TouristId, string ServiceProviderId, Email emailInstance)
        {
			System.MethodAccessException;
			System.AccessViolationException;
			System.UnauthorizedAccessException;
			System.MissingMethodException;
			System.NotImplementedException;
			System.ArgumentException;
			System.ArgumentNullException;
			System.ArgumentOutOfRangeException;
		}
		private void CommunicateViaMessages(string TouristId, string ServiceProviderId, Message MessagesInstance)
        {
			System.MethodAccessException;
			System.AccessViolationException;
			System.UnauthorizedAccessException;
			System.MissingMethodException;
			System.NotImplementedException;
			System.ArgumentException;
			System.ArgumentNullException;
			System.ArgumentOutOfRangeException;
		}
		private void CommunicateViaCalls(string TouristId, string ServiceProviderId, , Calls CallsInstance)
        {
			System.ArgumentException;
			System.ArgumentNullException;
			System.ArgumentOutOfRangeException;
			System.MethodAccessException;
			System.AccessViolationException;
			System.UnauthorizedAccessException;
			System.MissingMethodException;
			System.NotImplementedException;
		}
		private void CommunicateViaMeetings(string TouristId, string ServiceProviderId, Meetings MeetingsInstance)
        {
			System.ArgumentException;
			System.ArgumentNullException;
			System.ArgumentOutOfRangeException;
			System.MethodAccessException;
			System.AccessViolationException;
			System.UnauthorizedAccessException;
			System.MissingMethodException;
			System.NotImplementedException;
		}
	};
}


