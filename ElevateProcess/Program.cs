using System;
using System.Diagnostics;

namespace ElevateProcess
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 1)
            {
                Console.WriteLine("Usage: ep.exe <exe_path> [ <args> ] ");
                Environment.Exit(1);
            }

            ProcessStartInfo startInfo = new ProcessStartInfo(args[0])
            {
                Verb = "runas"
            };

            if (args.Length > 1)
            {
                string[] psargs = new string[args.Length - 1];
                Array.Copy(args, 1, psargs, 0, psargs.Length);
                startInfo.Arguments = String.Join(" ", psargs);
            }

            Process.Start(startInfo);
            Environment.Exit(0);
        }
    }
}
