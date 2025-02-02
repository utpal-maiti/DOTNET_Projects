using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xunit.Sdk;

namespace TestProject.xUnit.TestAttributes
{
    public class PriorityAttribute : Attribute, ITraitAttribute
    {
        public PriorityAttribute(int priority)
        {
            Priority = priority;
        }

        public int Priority { get; }

        public override string ToString() => $"Priority: {Priority}";
    }
}
