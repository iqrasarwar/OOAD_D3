using System;
using Admin;
using Validate;
using System.IO;

namespace Video
{
	class Video
	{

		//possible exceptions that can occur in the following methods. Refer to their code to  see how they can occur.


		Video()
        {
			System.IO.IOException;
			System.BadImageFormatException;
			System.InvalidCastException;
		}
		public void DeleteVideo()
        {
			System.AccessViolationException;
			System.MethodAccessException;
			System.ObjectDisposedException;
		}
		public void ApproveUpload()
        {
			System.AccessViolationException;
			System.MethodAccessException;
			System.ObjectDisposedException;
			System.MemberAccessException;
			System.MissingFieldException;
		}
		public void RequestModification()
        {
			System.IO.IOException;
			System.FieldAccessException;
			System.AccessViolationException;
			System.MethodAccessException;
			System.ObjectDisposedException;
			System.UnauthorizedAccessException;
		}
		public void RequestUpload()
        {
			System.IO.IOException;
			System.FieldAccessException;
			System.AccessViolationException;
			System.MethodAccessException;
			System.ObjectDisposedException;
			System.UnauthorizedAccessException;
		}
	};
}

