using Weedwacker.Shared.Commands;
using Weedwacker.WebServer;
using Weedwacker.WebServer.Commands;

WebServer.Start();


WebServerCommands.InitAll();


await ConsoleHandler.Start();