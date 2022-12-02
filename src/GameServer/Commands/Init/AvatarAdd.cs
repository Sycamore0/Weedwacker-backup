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
    // commands need to add
    internal static partial class GameServerCommands
    {

        private static void AvatarAdd()
        {
            #region addavatar command

            var AvatarIdArgument = new Argument<int>(name: "AvatarId");

            Command AddavatarCommand = new Command("addavatar", "Add avatar to player") { };

            AddavatarCommand.SetHandler(Weedwacker.GameServer.Commands.ConsoleCommands.OnAddAvatar,UserRank.Player ,AvatarIdArgument, guidArgument);
            AddavatarCommand.AddArgument(guidArgument);
            AddavatarCommand.AddArgument(AvatarIdArgument);

            ConsoleHandler.AddCommand(AddavatarCommand);

            #endregion
        }
        
    }
}
