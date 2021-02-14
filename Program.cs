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
                var processes = Process.GetProcesses().ToList().ToDictionary(i => $"{i.ProcessName} {i.Id}", i => i);
                var ps = Prompt.Select("Select Process", processes.Keys, 15);
                if (Prompt.Confirm("Are you sure to end " + ps, true)) processes[ps].Kill();
            }
        }
    }
}
