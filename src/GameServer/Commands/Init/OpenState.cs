using System;
using System.Collections.Generic;
using System.CommandLine;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weedwacker.Shared.Commands;
using Weedwacker.Shared.Enums;

namespace Weedwacker.GameServer.Commands
{
    internal partial class GameServerCommands
    {
        


        static void OpenState()
        {
            #region openstate command


            var OpenStateArgument = new Argument<int>(name: "OpenState");

            Command OpenStateCommand = new Command("openstate", "Set openstate for player");
            OpenStateCommand.AddArgument(guidArgument);

            OpenStateCommand.AddArgument(OpenStateArgument);

            OpenStateCommand.SetHandler(Weedwacker.GameServer.Commands.ConsoleCommands.OnOpenState,UserRank.Player, OpenStateArgument, guidArgument);

            ConsoleHandler.AddCommand(OpenStateCommand);

            #endregion
        }
    }
}
