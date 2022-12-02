using System.CommandLine;
using Weedwacker.Shared.Enums;

namespace Weedwacker.Shared.Commands
{
    public static partial class ConsoleCommands
    {
        public static async Task OnHashAbility(IConsole console, string arg)
        {
            await Task.Yield();
            console.WriteLine(Utils.Utils.AbilityHash(arg).ToString());
        }

        public static async Task OnHashPath(IConsole console, string args)
        {
            await Task.Yield();
            console.WriteLine(Utils.Utils.GetPathHash(args[0].ToString()).ToString());
        }
    }
}
