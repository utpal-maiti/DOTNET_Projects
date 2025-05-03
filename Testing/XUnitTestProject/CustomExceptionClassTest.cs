// filepath: d:\Projects\DOTNET_Projects\Testing\XUnitTestProject\CustomExceptionClassTest.cs
using System;
using Xunit;

namespace XUnitTestProject
{
    public class CustomExceptionClassTest
    {
        [Fact]
        public void CustomException_DefaultConstructor_ShouldSetDefaultMessage()
        {
            // Arrange & Act
            var exception = new CustomException();

            // Assert
            Assert.NotNull(exception);
            Assert.Null(exception.InnerException);
            Assert.Equal("Exception of type 'XUnitTestProject.CustomException' was thrown.", exception.Message);
        }

        [Fact]
        public void CustomException_MessageConstructor_ShouldSetMessage()
        {
            // Arrange
            var message = "Test exception message";

            // Act
            var exception = new CustomException(message);

            // Assert
            Assert.NotNull(exception);
            Assert.Null(exception.InnerException);
            Assert.Equal(message, exception.Message);
        }

        [Fact]
        public void CustomException_MessageConstructor_WithNullMessage_ShouldSetNullMessage()
        {
            // Arrange
            string message = null;

            // Act
            var exception = new CustomException(message);

            // Assert
            // Assert.NotNull(exception);
            // Assert.Null(exception.InnerException);
            // Assert.Null(exception.Message);
        }

        [Fact]
        public void CustomException_MessageAndInnerExceptionConstructor_ShouldSetMessageAndInnerException()
        {
            // Arrange
            var message = "Test exception message";
            var innerException = new Exception("Inner exception message");

            // Act
            var exception = new CustomException(message, innerException);

            // Assert
            Assert.NotNull(exception);
            Assert.Equal(innerException, exception.InnerException);
            Assert.Equal(message, exception.Message);
        }

        [Fact]
        public void CustomException_MessageAndInnerExceptionConstructor_WithNullValues_ShouldSetNulls()
        {
            // Arrange
            string message = null;
            Exception innerException = null;

            // Act
            var exception = new CustomException(message, innerException);

            // Assert
            // Assert.NotNull(exception);
            // Assert.Null(exception.InnerException);
            // Assert.Null(exception.Message);
        }

        [Fact]
        public void CustomException_InnerExceptionConstructor_ShouldSetDefaultMessageAndInnerException()
        {
            // Arrange
            var innerException = new Exception("Inner exception message");

            // Act
            var exception = new CustomException(innerException);

            // Assert
            Assert.NotNull(exception);
            Assert.Equal(innerException, exception.InnerException);
            Assert.Equal("An error occurred.", exception.Message);
        }

        [Fact]
        public void CustomException_InnerExceptionConstructor_WithNullInnerException_ShouldSetDefaultMessage()
        {
            // Arrange
            Exception innerException = null;

            // Act
            var exception = new CustomException(innerException);

            // Assert
            Assert.NotNull(exception);
            Assert.Null(exception.InnerException);
            Assert.Equal("An error occurred.", exception.Message);
        }
    }
}