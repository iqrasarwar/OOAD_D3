using System;
using System.Collections.Generic;
using EmailAPI;

namespace email
{
    class Email
    {
        //possible exceptions that can occur in the following methods. Refer to their code to  see how they can occur.

        Email()
        {
            System.InvalidCastException;
            System.ArithmeticException;
        }
        public void NewEmail()
        {
            System.IO.IOException;
        }
        public void MakeDraft()
        {
            System.IO.IOException;
        }
        public void SendEmail(string Content, string Receipent)
        {
            System.ArgumentException;
            System.ArgumentNullException;
            System.ArgumentOutOfRangeException;
            System.MethodAccessException;
            System.AccessViolationException;
            System.UnauthorizedAccessException;
        }
        public void ReceiveEmail()
        {
            System.MethodAccessException;
            System.AccessViolationException;
            System.UnauthorizedAccessException;
        }
        public void DiscardDraft(string Emailid)
        {
            System.ArgumentException;
            System.ArgumentNullException;
            System.ArgumentOutOfRangeException;
            System.IndexOutOfRangeException;
        }
        public void DeleteEmail(string EmailId)
        {
            System.ArgumentException;
            System.ArgumentNullException;
            System.ArgumentOutOfRangeException;
            System.IndexOutOfRangeException;
        }
        public void ReportEmail(string EmailId)
        {
            System.ArgumentException;
            System.ArgumentNullException;
            System.ArgumentOutOfRangeException;
            System.IO.IOException;
            System.MethodAccessException;
            System.AccessViolationException;
            System.UnauthorizedAccessException;
        }
    };
}

