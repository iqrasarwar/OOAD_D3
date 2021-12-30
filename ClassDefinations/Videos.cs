using System;
using Admin;
using Validate;
using System.IO;

namespace Video
{
	class Video
	{

		private string Video;
		private string vidId;
		private readonly DateTime dateTime = DateTime.Now;
		private string Status;
		private Admin admin;
		private NewsFeed feed;

		Video();
		public void DeleteVideo();
		public void ApproveUpload();
		public void RequestModification();
		public void RequestUpload();
	};
}

