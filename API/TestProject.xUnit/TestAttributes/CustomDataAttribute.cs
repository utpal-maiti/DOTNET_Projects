using System.Reflection;

using Xunit.Sdk;

namespace TestProject.xUnit.TestAttributes
{
    public class CustomDataAttribute : DataAttribute
    {
        public override IEnumerable<object[]> GetData(MethodInfo testMethod)
        {
            yield return new object[] { 1, 2, 3 };
            yield return new object[] { 4, 5, 9 };
        }
    }
}
