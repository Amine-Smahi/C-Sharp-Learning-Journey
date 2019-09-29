using System;
using System.ComponentModel.DataAnnotations;
using Figgle;
using McMaster.Extensions.CommandLineUtils;

namespace Goli
{
    class Program
{
    static int Main(string[] args)
    {
        if (args.Length >= 1)
        {
            var text = string.Empty;
            foreach (var arg in args)
            {
                text += $" {arg}";
            }
            Console.WriteLine(FiggleFonts.Standard.Render(text));
            return 0;
        }
        else
        {
            Console.WriteLine("Error : Text option missing. Banner <text>");
            return -1;
        }
    }
}
}
