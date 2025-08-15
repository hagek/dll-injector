public class ProcItem
{
    public string Name { get; init; }
    public int ProcessId { get; init; }
    public string ExecutablePath { get; init; }
    public string CommandLine { get; init; }
    public Bitmap? Icon { get; init; }

    public override string ToString()
    {
        return $"{this.Name} (PID: {this.ProcessId})";
    }
}