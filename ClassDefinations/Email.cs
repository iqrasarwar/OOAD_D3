using System;
using System.Collections.Generic;
using EmailAPI;

namespace email
{
    class Email
    {
        private readonly DateTime dateTime = DateTime.Now;
        private string Content;
        private string Receipent;
        private readonly string myEmail = "mymail@gmail.com";
        private string EmailId;
        private static List<Email> drafts = new List<Email>();
        private static List<Email> received = new List<Email>();
        private static List<Email> sent = new List<Email>();

        Email();
        public void NewEmail();
        public void MakeDraft();
        public void SendEmail(string Content, string Receipent);
        public void ReceiveEmail();
        public void DiscardDraft(string Emailid);
        public void DeleteEmail(string EmailId);
        public void ReportEmail(string EmailId);
    };
}

