using System;
using System.Collections.Generic;
using System.CommandLine;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Weedwacker.Shared.Enums;
using Weedwacker.Shared.Utils;

namespace Weedwacker.Shared.Commands
{
    public class ShellCommand : Command
    {
        public ShellCommand(string name, string? description = null) : base(name, description)
        {
        }

        public class ExecuteEventArgs : EventArgs
        {
            public IConsole console;

            public string[] args;

            public ExecuteEventArgs(string[] args,IConsole console)
            {
                this.console = console;
                this.args = args;
            }
        }

        public delegate void OnExecute(object sender, ExecuteEventArgs e);


        public UserRank RequiredRank { get; private set; }



        public void SetRequiredRank (UserRank requiredRank)
        {
            this.RequiredRank = requiredRank;
        }


    }
}
