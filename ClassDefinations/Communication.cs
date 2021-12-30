using System;
using Email;
using Calls;
using BlogPosts;
using Meetings;

namespace communication
{
	public class Communication
	{
		public string SenderId;
		public string ReceiverId;
		public string Type;

		private void CommunicateViaEmail(string TouristId, string ServiceProviderId, Email emailInstance);
		private void CommunicateViaMessages(string TouristId, string ServiceProviderId, Message MessagesInstance);
		private void CommunicateViaCalls(string TouristId, string ServiceProviderId, , Calls CallsInstance);
		private void CommunicateViaMeetings(string TouristId, string ServiceProviderId, Meetings MeetingsInstance);
	};
}


