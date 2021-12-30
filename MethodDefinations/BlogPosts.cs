using System;
using Admin;
using Validate;
using System.IO;

namespace blogPosts
{
	public class BlogPosts
	{
		private string Video { get; set; }
		private readonly DateTime dateTime = DateTime.Now;
		private string Status { get; set; }
		private string	BlogPostid { get; set; }
		private string content { get; set; }
		private string Image { get; set; }
		private Admin admin { get; set; }
		private NewsFeed feed { get; set; }
		DateTime dateTime { get; }

		BlogPosts()
        {
			static int id= 1;
			this.BlogPostid = Convert.ToString(id);
			id++;
			Status = false;
			Console.WriteLine("Enter Video address");
			Video = Console.ReadLine();
			Console.WriteLine("Enter Image address");
			Image = Console.ReadLine();
			Console.WriteLine("Enter post content");
			Content = Console.ReadLine();
			admin = new Admin();
			feed = new NewsFeed();
		}
		public void RequestUpload()
        {
			if (Validate.isvalid(this))
			{
				admin.ApproveBlogPost(this);
				if (Status == true)
					feed.AddBlogPost(this);
				else
				{
					Console.WriteLine("Admin Approval denied!");
					DeletePost(this);
				}
			}
			else
			{
				Console.WriteLine("In appropriate Content! Validation falid.");
				DeletePost(this);
			}
        }
		public void RequestModification()
        {
			BlogPosts temp = new BlogPosts();
			Console.WriteLine("Enter new video address");
			temp.Video = Console.ReadLine();
			Console.WriteLine("Enter new image address");
			temp.Image = Console.ReadLine();
			Console.WriteLine("Enter new post content");
			temp.Content = Console.ReadLine();
			if (Validate.isvalid(temp))
			{
				admin.ApproveBlogPost(temp);
				if (Status == true)
                {
					feed.AddBlogPost(temp);
					feed.DeleteBlogPost(this);
				}
				else
				{
					Console.WriteLine("Admin Approval denied!");
					DeletePost(temp);
				}
			}
			else
			{
				Console.WriteLine("In appropriate Content! Validation falid.");
				DeletePost(temp);
			}
		}
		public void DeletePost()
        {
			feed.DeleteBlogPost(this);
		}
		public void ApproveUpload()
        {
			this.Status = true;
        }
	}
};
