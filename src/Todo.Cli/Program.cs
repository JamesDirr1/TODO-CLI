using System.CommandLine;

RootCommand rootCommand = new RootCommand("A simple todo application");

Command statusCommand = new Command("status", "Shows the current todo status");

statusCommand.SetAction(parseResult =>
{
    Console.WriteLine("Todo is ready.");
});

rootCommand.Subcommands.Add(statusCommand);

return rootCommand.Parse(args).Invoke();