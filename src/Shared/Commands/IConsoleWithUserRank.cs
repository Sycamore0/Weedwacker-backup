using System;
using System.Collections.Generic;
using System.CommandLine;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weedwacker.Shared.Enums;

namespace Weedwacker.Shared.Commands
{
    public interface IConsoleWithUserRank:IConsole
    {
        public UserRank rank { get; }
    }
}
