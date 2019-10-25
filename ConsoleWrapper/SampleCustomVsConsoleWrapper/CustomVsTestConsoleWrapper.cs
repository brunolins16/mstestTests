using Microsoft.TestPlatform.VsTestConsole.TranslationLayer;

namespace SampleCustomVsConsoleWrapper
{
    public class CustomVsTestConsoleWrapper : VsTestConsoleWrapper
    {
        public CustomVsTestConsoleWrapper(string vstestConsolePath) : base(vstestConsolePath)
        {
        }

        public CustomVsTestConsoleWrapper(string vstestConsolePath, ConsoleParameters consoleParameters) : base(vstestConsolePath, consoleParameters)
        {
        }
    }
}
