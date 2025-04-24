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

    public class ExceptionHandlingClass
    {
        public string MethodWithExceptionHandling()
        {
            try
            {
                // Simulate an error
                // throw new CustomException("An error occurred.");
            }
            catch (CustomException ex)
            {
                // Catch the exception and throw a custom exception
                throw new CustomException(ex.Message, ex);
            }

            catch (Exception ex)
            {
                // Catch the exception and throw a custom exception

            }
            return "Successfully executed method without exceptions.";
        }
    }
}