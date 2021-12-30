using System;
using Admin;
using Validate;
using System.IO;

namespace blogPosts
{
	public class BlogPosts
	{
		private string Video;
		private readonly DateTime dateTime = DateTime.Now;
		private string Status;
		private string BlogPostid;
		private string content;
		private string Image;
		private Admin admin;
		private NewsFeed feed;

		BlogPosts();
		public void RequestUpload();
		public void RequestModification();
		public void DeletePost();
		public void ApproveUpload();

	}
};
