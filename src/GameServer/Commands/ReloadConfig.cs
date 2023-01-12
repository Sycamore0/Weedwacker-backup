using System.CommandLine;
using Weedwacker.Shared.Commands;
using Weedwacker.Shared.Enums;
using Weedwacker.Shared.Utils;
using Weedwacker.Shared.Utils.Configuration;

namespace Weedwacker.GameServer.Commands
{
    internal static partial class GameServerCommands
    {
        private static void InitReloadConfig()
        {
            Command reloadCommand = new("reloadconfig", "reloads GameConfig.json");

            reloadCommand.SetHandler(OnReloadConfig, UserRank.Console);

            ConsoleHandler.AddCommand(reloadCommand);
        }
        internal static async Task OnReloadConfig(IConsole console)
        {
            try
            {
                GameConfig config = await Config.Load<GameConfig>("GameConfig.json");
                GameServer.Configuration = config;
                console.WriteLine($"reloaded GameConfig");
            }
            catch(Exception e)
            {
                Logger.WriteErrorLine("An error occured while reloading GameConfig.json", e);
            }
        }
    }
}
