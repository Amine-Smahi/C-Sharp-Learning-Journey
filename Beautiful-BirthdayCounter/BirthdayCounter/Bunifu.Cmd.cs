using System.Diagnostics;

namespace Bunifu.Framework.Lib
{
    [DebuggerStepThrough]
    internal static class cmd
    {
        private static Process process1;


        internal static void EXECUTECMD(string CMD)
        {
            process1 = new Process();
            process1.StartInfo.FileName = "CMD.exe";
            process1.StartInfo.Arguments = "/C " + CMD;
            process1.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process1.Start();
            process1.WaitForExit();
        }
    }
}