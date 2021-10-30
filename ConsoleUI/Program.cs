using System;
using System.IO;
using System.Runtime.Serialization;
using ExceptionsLibrary;

namespace ConsoleUI
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                throw new UserAlreadyLoggedInException("User is logged in - no duplicate sessions allowed", new ArgumentException());
            }
            catch (UserAlreadyLoggedInException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException);
            }
        }
    }

    [Serializable]
    public class UserAlreadyLoggedInException : Exception
    {
        public UserAlreadyLoggedInException()
            : base()
        {
        }

        public UserAlreadyLoggedInException(string message)
            : base(message)
        {
        }

        public UserAlreadyLoggedInException(string message, Exception innerException) 
            : base(message, innerException)
        {
        }

        public UserAlreadyLoggedInException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}