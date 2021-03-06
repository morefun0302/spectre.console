using Spectre.Console;

namespace GridExample
{
    public static class Program
    {
        public static void Main()
        {
            AnsiConsole.WriteLine();
            AnsiConsole.MarkupLine("Usage: [grey]dotnet [blue]run[/] [[options]] [[[[--]] <additional arguments>...]]]][/]");
            AnsiConsole.WriteLine();

            var grid = new Grid();
            grid.AddColumn(new GridColumn { NoWrap = true });
            grid.AddColumn(new GridColumn { NoWrap = true, Width = 2 });
            grid.AddColumn();
            grid.AddRow("Options:", "", "");
            grid.AddRow("  [blue]-h[/], [blue]--help[/]", "", "Show command line help.");
            grid.AddRow("  [blue]-c[/], [blue]--configuration[/] <CONFIGURATION>", "", "The configuration to run for.");
            grid.AddRow("  [blue]-v[/], [blue]--verbosity[/] <LEVEL>", "", "Set the [grey]MSBuild[/] verbosity level.");

            AnsiConsole.Render(grid);
        }
    }
}
