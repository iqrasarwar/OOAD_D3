using System;
using Admin;
using Validate;
using System.IO;

namespace Video
{
	class Video
	{

		private string Video { get; set; }
		private string vidId { get; set; }
		private readonly DateTime dateTime = DateTime.Now;
		private string Status { get; set; }
		private Admin admin { get; set; }
		private NewsFeed feed { get; set; }
		DateTime dateTime { get; }

        Video()
        {
			static int id = 1;
			this.vidId = Convert.ToString(id);
			id++;
			Status = false;
			Console.WriteLine("Enter video address");
			Image = Console.ReadLine();
			admin = new Admin();
			feed = new NewsFeed();
		}
		public void DeleteVideo(string vidId)
        {
			feed.DeleteVideo(this);
		}
		public void ApproveUpload(string vidId)
        {
			this.Status = true;
		}
		public void RequestModification(string vidId)
		{
			Video temp = new Video();
			Console.WriteLine("Enter new video address");
			temp.Video = Console.ReadLine();
			if (Validate.isvalid(temp))
			{
				admin.ApproveVideo(temp);
				if (Status == true)
				{
					feed.AddVideo(temp);
					feed.DeleteVideo(this);
				}
				else
				{
					Console.WriteLine("Admin Approval denied!");
					Deletevideo(temp);
				}
			}
			else
			{
				Console.WriteLine("In appropriate Content! Validation falid.");
				DeleteVideo(temp);
			}
		}
		public void RequestUpload(string vidId)
		{
			if (Validate.isvalid(this))
			{
				admin.ApproveVideo(this);
				if (Status == true)
					feed.AddVideo(this);
				else
				{
					Console.WriteLine("Admin Approval denied!");
					DeleteVideo(this);
				}
			}
			else
			{
				Console.WriteLine("In appropriate Content! Validation falid.");
				DeleteVideo(this);
			}
		}
	};
}

