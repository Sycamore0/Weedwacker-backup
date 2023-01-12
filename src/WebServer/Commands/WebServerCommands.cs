using System.CommandLine;
using System.Reflection;
using Weedwacker.Shared.Commands;
using Weedwacker.Shared.Utils;

namespace Weedwacker.WebServer.Commands
{
    internal partial class WebServerCommands
    {
        // general arguments
        private static Argument<int> guidArgument = new Argument<int>(name: "uid");
        private static Argument<int> idArgument = new Argument<int>(name: "id");


        public static void InitAll()
        {
            ConsoleHandler.Init();

            Type thisType = typeof(WebServerCommands);
            IEnumerable<MethodInfo> methods = thisType.GetMethods(BindingFlags.NonPublic | BindingFlags.Static).Where(w => w.Name.StartsWith("Init"));
            foreach (MethodInfo method in methods)
            {
                if (method.IsPrivate)
                    method.Invoke(null, null);
                else
                {
                    if (method.Name != "InitAll")
                        Logger.DebugWriteWarningLine("Init methods must be private!");
                }
            }
        }


    }
}
