using System;
using Xunit;

namespace XUnitTestProject
{
    public class UnitTest1
    {
        [Fact]
        public void TestMethod1()
        {
            Assert.True(true);
        }
    }

    public class ExceptionHandlingClassTests
    {
        [Fact]
        public void MethodWithExceptionHandling_ShouldThrowCustomException_WhenInvalidOperationExceptionOccurs()
        {
            // Arrange
            var exceptionHandlingClass = new ExceptionHandlingClass();

            // Act & Assert
            var exception = Assert.Throws<CustomException>(() => exceptionHandlingClass.MethodWithExceptionHandling());
            Assert.Equal("An error occurred.", exception.Message);
        }

        [Fact]
        public void MethodWithExceptionHandling_ShouldReturnSuccessMessage_WhenNoExceptionOccurs()
        {
            // Arrange
            var exceptionHandlingClass = new ExceptionHandlingClass();

            // Act
            var result = exceptionHandlingClass.MethodWithExceptionHandling();

            // Assert
            Assert.Equal("Successfully executed method without exceptions.", result);
        }

        [Fact]
        public void MethodWithExceptionHandling_ShouldHandleGenericException()
        {
            // Arrange
            var exceptionHandlingClass = new ExceptionHandlingClass();

            // Modify the method to simulate a generic exception if needed
            // For now, this test assumes the generic exception path is reachable.

            // Act & Assert
            var exception = Assert.Throws<CustomException>(() => exceptionHandlingClass.MethodWithExceptionHandling());

        }
    }
}
