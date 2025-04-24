using Xunit.Sdk;

namespace TestProject.xUnit.TestAttributes
{
    [TraitDiscoverer("Namespace.PriorityDiscoverer", "AssemblyName")]
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class MethodPriorityAttribute : Attribute, ITraitAttribute
    {
        public int Priority { get; }

        public MethodPriorityAttribute(int priority)
        {
            Priority = priority;
        }
    }
}
