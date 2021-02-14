using Sharprompt;
using System.Diagnostics;
using System.Linq;

namespace mRengar
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var processes = Process.GetProcesses().ToList().ToDictionary(i => $"{i.ProcessName}:{i.Id}", i => i);
                var ps = Prompt.Select("Select process you wish to end", processes.Keys);
                if (Prompt.Confirm("Are you sure to end " + ps)) processes[ps].Kill();
            }
        }
    }
}
