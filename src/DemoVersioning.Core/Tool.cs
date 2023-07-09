using System.Diagnostics;
using System.Reflection;

namespace DemoVersioning.Core
{
    public static class Tool
    {
        public static string GetAssemblyVersion() => Assembly.GetExecutingAssembly().GetName().Version.ToString();

        public static string GetFileVersion() => FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion;

        public static string GetProductVersion() => FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).ProductVersion;
    }
}
