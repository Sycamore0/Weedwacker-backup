using System.CommandLine;
using System.Reflection;
using Weedwacker.Shared.Commands;
using Weedwacker.Shared.Utils;

namespace Weedwacker.GameServer.Commands
{
    internal partial class GameServerCommands
    {
        // general arguments
        private static Argument<int> guidArgument = new Argument<int>(name: "uid");
        private static Argument<int> idArgument = new Argument<int>(name: "id");

        internal static void InitAll()
        {
            ConsoleHandler.Init();

            Type thisType = typeof(GameServerCommands);
            IEnumerable<MethodInfo> methods = thisType.GetMethods(BindingFlags.NonPublic | BindingFlags.Static).Where(w => w.Name.StartsWith("Init"));
            foreach(MethodInfo method in methods)
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
