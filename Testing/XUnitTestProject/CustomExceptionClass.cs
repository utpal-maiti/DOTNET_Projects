using System;

namespace XUnitTestProject
{
    // Define a custom exception
    public class CustomException : Exception
    {
        public CustomException() : base()
        {
        }

        public CustomException(string message) : base(message)
        {
        }

        public CustomException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public CustomException(Exception innerException) : base("An error occurred.", innerException)
        {
        }
    }
}