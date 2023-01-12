using System.CommandLine;
using Weedwacker.Shared.Commands;
using Weedwacker.Shared.Enums;
using Weedwacker.WebServer.Database;

namespace Weedwacker.WebServer.Commands
{
    internal partial class WebServerCommands
    {
        private static void InitCreateAccount()
        {
            var passwordOption = new Option<string>(
                name: "-p",
                description: "account's password");

            var uidOption = new Option<string>(
                name: "-u",
                description: "account's uid", getDefaultValue: () => "0");

            var nameArgument = new Argument<string>(name: "username");

            Command accountCommand = new("account", "Account related operations") { };
            Command createCommand = new("create", "Create an account") { };

            createCommand.AddAlias("add");
            createCommand.AddArgument(nameArgument);
            createCommand.AddOption(uidOption);
            createCommand.AddOption(passwordOption);

            createCommand.SetHandler(OnCreateAccount, UserRank.Console, nameArgument, uidOption, passwordOption);

            accountCommand.AddCommand(createCommand);

            ConsoleHandler.AddCommand(accountCommand);
        }

        public static async Task OnCreateAccount(IConsole con, string name, string uid,string pwd)
        {
            if (string.IsNullOrEmpty(name))
            {
                con.WriteLine($"Username is invalid");
                return;
            }
            Account? account = await DatabaseManager.GetAccountByNameAsync(name);
            if (account != null)
            {
                con.WriteLine($"Username {name} already exists!");
            }
            else
            {
                DatabaseManager.CreateAccountWithUid(username:name,password:pwd,uid:uid);

                con.WriteLine($"Successfully created account {name}");
            }
        }
    }
}
