using System;
using Admin;
using Validate;
using System.IO;

namespace pictures
{
	class Pictures
	{
		private string Image { get; set; }
		private string imgId { get; set; }
		private readonly DateTime dateTime = DateTime.Now;
		private string Status { get; set; }
		private Admin admin { get; set; }
		private NewsFeed feed { get; set; }
		DateTime dateTime { get; }

		Pictures()
		{
			static int id = 1;
			this.imgId = Convert.ToString(id);
			id++;
			Status = false;
			Console.WriteLine("Enter Image address");
			Image = Console.ReadLine();
			admin = new Admin();
			feed = new NewsFeed();
		}
		public void RequestModification(string imgId)
        {
			Pictures temp = new Pictures();
			Console.WriteLine("Enter new image address");
			temp.Image = Console.ReadLine();
			if (Validate.isvalid(temp))
			{
				admin.ApprovePicture(temp);
				if (Status == true)
				{
					feed.AddPicture(temp);
					feed.DeletePicture(this);
				}
				else
				{
					Console.WriteLine("Admin Approval denied!");
					DeletePicture(temp);
				}
			}
			else
			{
				Console.WriteLine("In appropriate Content! Validation falid.");
				DeletePicture(temp);
			}
		}
		public void DeletePicture(string imgId)
        {
			feed.DeletePicture(this);
		}
		public void ApproveUpload(string imgId)
        {
			this.Status = true;
		}
		public void RequestUpload(string imgId)
        {
			if (Validate.isvalid(this))
			{
				admin.ApprovePicture(this);
				if (Status == true)
					feed.AddPicture(this);
				else
				{
					Console.WriteLine("Admin Approval denied!");
					DeletePicture(this);
				}
			}
			else
			{
				Console.WriteLine("In appropriate Content! Validation falid.");
				DeletePicture(this);
			}
		}
	};
}
