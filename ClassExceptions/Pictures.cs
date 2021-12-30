using System;
using Admin;
using Validate;
using System.IO;

namespace pictures
{
	class Pictures
	{
		//possible exceptions that can occur in the following methods. Refer to their code to  see how they can occur.


		Pictures()
        {
			System.IO.IOException;
			System.BadImageFormatException;
			System.InvalidCastException;
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
		public void DeletePicture()
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
