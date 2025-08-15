using System.Diagnostics;
using System.Management;

namespace dll_injector
{
    internal class ProcessManager
    {
        private readonly List<ProcItem> processes = new List<ProcItem>();

        public void LoadProcesses()
        {
            this.processes.Clear();

            var searcher = new ManagementObjectSearcher("SELECT ProcessId, CommandLine FROM Win32_Process");
            var cmdLines = new Dictionary<int, string>();

            foreach (var obj in searcher.Get())
            {
                try
                {
                    int processId = Convert.ToInt32(obj["ProcessId"]);
                    string? cmdLine = obj["CommandLine"]?.ToString();
                    if (!string.IsNullOrEmpty(cmdLine))
                    {
                        cmdLines[processId] = cmdLine;
                    }
                }
                catch (Exception) { }
            }

            foreach (var process in Process.GetProcesses())
            {
                string? exePath = null;
                Bitmap? icon = null;
                try
                {
                    exePath = process.MainModule?.FileName;
                    if (!string.IsNullOrEmpty(exePath))
                    {
                        icon = Icon.ExtractAssociatedIcon(exePath)?.ToBitmap();
                    }
                }
                catch (Exception) { }

                cmdLines.TryGetValue(process.Id, out string? commandLine);

                this.processes.Add(new ProcItem
                {
                    Icon = icon,
                    Name = process.ProcessName,
                    ProcessId = process.Id,
                    ExecutablePath = exePath ?? string.Empty,
                    CommandLine = commandLine ?? string.Empty
                });
            }
        }

        public IReadOnlyCollection<ProcItem> GetProcItems()
        {
            return this.processes.AsReadOnly();
        }

    }
}