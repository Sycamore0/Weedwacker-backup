using System.CommandLine;
using Weedwacker.Shared.Enums;
using Weedwacker.Shared.Utils;

namespace Weedwacker.Shared.Commands
{
    public static partial class ConsoleHandler
    {
        public static void Init()
        {

            Command hashabilityCommand = new("hashability", "hashability command");
            Command hashpathCommand = new("hashpath", "hashpath command");


            var valueArgument = new Argument<string>(
                name: "value");


            hashabilityCommand.AddArgument(valueArgument);
            hashpathCommand.AddArgument(valueArgument);

            hashabilityCommand.SetHandler(ConsoleCommands.OnHashAbility, UserRank.Console, valueArgument);
            hashpathCommand.SetHandler(ConsoleCommands.OnHashPath, UserRank.Console, valueArgument);


            AddCommand(hashpathCommand);
            AddCommand(hashabilityCommand);
        }

        public static Command RootCommand { get; private set; } = new Command("/");


        public static void AddCommand(Command command)
        {
            RootCommand.AddCommand(command);
        }
        public static async Task Start()
        {
            Start:
            try
            {
            CommandHandler:
                Console.Write(">");
                var args = ParseCommandString(Console.ReadLine().Trim());
                if (args.Length > 0)
                {
                    try
                    {
                        var console = new SimConsole(UserRank.Console);
                        await RootCommand.InvokeAsync(args, console);
                        var ret = console.Out.ToString().TrimEnd('\n'); ;
                        //var err = console.Error.ToString(); //err is null
                        Logger.WriteLine(Environment.NewLine + ret);

                    }
                    catch (Exception ex)
                    {
                        Logger.WriteErrorLine(ex.Message);
                    }
                }
                goto CommandHandler;
            }
            catch (Exception e)
            {
                Logger.WriteErrorLine(e.ToString());
            }
            goto Start;
        }
        #region Parse cmd_str to arg list
        public static string[] ParseCommandString(string? input)
        {
            IList<string> args = new List<string>();
            args = input.Split(' ');
            if (input.Contains('\"'))
            {
                List<string> finalArgs = new();
                string tmp = string.Empty;
                short idx = -1;
                for (short i = 0; i < args.Count; i++)
                {
                    if (idx < 0)
                    {
                        if (args[i].StartsWith("\"") && !args[i].EndsWith("\""))
                        {
                            idx = i;
                            tmp = $"{args[i]} ";
                            continue;
                        }
                    }
                    else
                    {
                        if (args[i].EndsWith("\""))
                        {
                            tmp += args[i];
                            finalArgs.Add(tmp.Replace("\"", string.Empty));
                            tmp = string.Empty;
                            idx = -1;
                        }
                        else
                            tmp += $"{args[i]} ";
                        continue;
                    }
                    finalArgs.Add(args[i]);
                }
                if (idx < 0)
                    args = finalArgs.ToArray();
            }
            return args.ToArray();
        }
        #endregion

    }
}
