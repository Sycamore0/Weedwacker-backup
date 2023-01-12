using Newtonsoft.Json;
using System.CommandLine;
using Weedwacker.Shared.Commands;
using Weedwacker.Shared.Enums;

namespace Weedwacker.GameServer.Commands
{
    internal static partial class GameServerCommands
    {
        private static void InitExportHashes()
        {
            Command exporthashesCommand = new("exporthashes", "exported ability hashes");

            exporthashesCommand.SetHandler(OnExportHashes, UserRank.Console);

            ConsoleHandler.AddCommand(exporthashesCommand);
        }
        internal static async Task OnExportHashes(IConsole console)
        {
            string jsonString = JsonConvert.SerializeObject(GameServer.AbilityNameHashMap, Formatting.Indented);
            await File.WriteAllTextAsync("ability_hashMap.json", jsonString);

            console.WriteLine($"exported ability hashes") ;
        }
    }
}
