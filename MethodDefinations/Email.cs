using System;
using System.Collections.Generic;
using EmailAPI;

namespace email
{
    class Email
    {
        private readonly DateTime dateTime = DateTime.Now;
        private string Content { get; set; }
        private string Receipent { get; set; }
        private readonly string myEmail = "mymail@gmail.com";
        private string EmailId { get; set; }
        private static List<Email> drafts = new List<Email>();
        private static List<Email> received= new List<Email>();
        private static List<Email> sent = new List<Email>();
        DateTime dateTime { get; }
        string myEmail { get; }

        Email()
        {
            static int id = 1;
            this.EmailId = Convert.ToString(id);
            id++;
            Content = "";
            Receipent = "";
        }
        public void NewEmail()
        {
            Console.WriteLine("Enter email content");
            this.Content = Console.ReadLine();
            Console.WriteLine("Enter recepient email");
            this.Receipent = Console.ReadLine();
        }
        public void MakeDraft()
        {
            Email temp;
            Console.WriteLine("Enter email content");
            temp.Content = Console.ReadLine();
            Console.WriteLine("Enter recepient email");
            temp.Receipent = Console.ReadLine();
            drafts.Add(temp);
        }
        public void SendEmail(string Content, string Receipent)
        {
            NewEmail();
            EmailAPI.initiateNew(this.myEmail, Receipent, Content);
            sent.Add(this);
        }
        public void ReceiveEmail()
        {
            NewEmail();
            EmailAPI.initiateNew(Receipent, this.myEmail, Content);
            received.Add(this);
        }
        public void DiscardDraft(string Emailid)
        {
            foreach(Email e in drafts)
            {
                if(drafts[e].EmailId == EmailId)
                {
                    drafts.Remove(drafts[e]);
                }
            }
        }
        public void DeleteEmail(string EmailId)
        {
            foreach (Email e in received)
            {
                if (received[e].EmailId == EmailId)
                {
                    drafts.Remove(received[e]);
                }
            }
            foreach (Email e in sent)
            {
                if (sent[e].EmailId == EmailId)
                {
                    drafts.Remove(sent[e]);
                }
            }
        }
        public void ReportEmail(string EmailId)
        {
            Console.WriteLine("Enter Complain");
            string complain = Console.ReadLine();
            EmailAPI.initiatReport(EmailId, complain);
        }
    };
}

