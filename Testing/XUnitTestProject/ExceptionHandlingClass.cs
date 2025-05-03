namespace XUnitTestProject
{
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