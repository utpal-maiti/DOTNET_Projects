using Xunit.Abstractions;
using Xunit.Sdk;

namespace TestProject.xUnit.TestAttributes
{
    public class PriorityDiscoverer : ITraitDiscoverer
    {
        public IEnumerable<KeyValuePair<string, string>> GetTraits(IAttributeInfo traitAttribute)
        {
            var priority = traitAttribute.GetConstructorArguments().First();
            yield return new KeyValuePair<string, string>("Priority", value: priority.ToString()!);
        }
    }
}
