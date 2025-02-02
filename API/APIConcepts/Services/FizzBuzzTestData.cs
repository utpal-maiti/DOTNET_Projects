using System.Collections;

namespace TestProject.xUnit.DataSource
{
    public class FizzBuzzTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { 3, "Fizz" };
            yield return new object[] { 5, "Buzz" };
            yield return new object[] { 15, "FizzBuzz" };
            yield return new object[] { 4, "4" };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}