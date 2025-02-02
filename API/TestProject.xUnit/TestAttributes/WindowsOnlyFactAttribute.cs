using System.Runtime.InteropServices;

namespace TestProject.xUnit.TestAttributes
{
    public class WindowsOnlyFactAttribute : FactAttribute
    {
        public WindowsOnlyFactAttribute()
        {
            if (!RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                Skip = "This test runs only on Windows.";
            }
        }
    }
}
