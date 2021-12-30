using System;
using Email;
using Calls;
using BlogPosts;
using Meetings;

namespace communication
{
	public class Communication
	{
		private string SenderId { get; set; }
		private string ReceiverId { get; set; }
		private string Type { get; set; }

		public void CommunicateViaEmail(string TouristId, string ServiceProviderId, Email emailInstance, int direction)
        {
			Type = "Email";
			if (direction == 1)
			{
				SenderId = TouristId;
				ReceiverId = ServiceProviderId;
				emailInstance.Recepient = Tourist.getEmail(TouristId);
				emailInstance.myEmail = ServiceProvider.getEmail(ServiceProviderId);
				emailInstance.SendEmail()
			}
			else
			{
				SenderId = ServiceProviderId;
				ReceiverId = TouristId;
				emailInstance.Recepient = ServiceProvider.getEmail(ServiceProviderId);
				emailInstance.myEmail = Tourist.getEmail(TouristId); 
				emailInstance.SendEmail()
			}
		}
		public void CommunicateViaMessages(string TouristId, string ServiceProviderId, Message MessagesInstance, int direction)
        {
			Type = "Message";
			if (direction == 1)
			{
				SenderId = TouristId;
				ReceiverId = ServiceProviderId;
				MessagesInstance.Recepient = Tourist.getEmail(TouristId);
				MessagesInstance.SendMessage();
			}
			else
			{
				SenderId = ServiceProviderId;
				ReceiverId = TouristId;
				MessagesInstance.Recepient = ServiceProvider.getEmail(ServiceProviderId);
				MessagesInstance.SendMessage();
			}
		}
		public void CommunicateViaCalls(string TouristId, string ServiceProviderId, Calls CallsInstance, int direction)
        {
			Type = "Call";
			if (direction == 1)
			{
				SenderId = TouristId;
				ReceiverId = ServiceProviderId;
				CallsInstance.Recepient = Tourist.getNumber(TouristId);
				CallsInstance.SNumber = ServiceProvider.getNumber(ServiceProviderId);
				CallsInstance.NewCall();
			}
			else
			{
				SenderId = ServiceProviderId;
				ReceiverId = TouristId; 
				CallsInstance.Recepient = ServiceProvider.getNumber(ServiceProviderId);
				CallsInstance.SNumber = Tourist.getNumber(TouristId);
				CallsInstance.NewCall();
			}
		}
		public void CommunicateViaMeetings(string TouristId, string ServiceProviderId, Meetings MeetingsInstance, int direction)
        {
			Type = "Meet";
			if (direction == 1)
			{
				SenderId = TouristId;
				ReceiverId = ServiceProviderId;
				MeetInstance.Recepient = Tourist.getEmail(TouristId);
				MeetInstance.ScheduleNewMeeting()
			}
			else
			{
				SenderId = ServiceProviderId;
				ReceiverId = TouristId;
				MeetInstance.Recepient = ServiceProvider.getEmail(ServiceProviderId);
				MeetInstance.ScheduleNewMeeting()
			}
		}
	};
}


