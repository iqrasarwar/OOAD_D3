using System;
using Admin;
using Validate;
using System.IO;

namespace pictures
{
	class Pictures
	{
		private string Image;
		private string imgId;
		private readonly DateTime dateTime = DateTime.Now;
		private string Status;
		private Admin admin;
		private NewsFeed feed;

		Pictures();
		public void RequestModification();
		public void DeletePicture();
		public void ApproveUpload();
		public void RequestUpload();
	};
}
