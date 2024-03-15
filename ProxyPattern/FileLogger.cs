

public class FileLogger : ILogger
{
    public void Log(string message)
    {
        message = $"[{DateTime.Now:dd.mm.yyyy}] - {message}";
        File.AppendAllText("Messages.txt", message);
    }
    public void Log(IEnumerable<string> messages)
    {
        File.AppendAllText("Messages.txt", string.Join(Environment.NewLine ,messages));
    }

}

