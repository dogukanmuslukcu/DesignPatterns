public class BufferedFileLoggerProxy : ILogger
{
    private readonly int _bufferSize;
    private readonly FileLogger _logger;
    private List<string> _logs;
    public BufferedFileLoggerProxy(int bufferSize)
    {
        _bufferSize = bufferSize;
        _logs = new List<string>(capacity:bufferSize);
        _logger = new FileLogger();
    }
    public void Log(string message)
    {
        if (_bufferSize < _logs.Count()) 
        {
            foreach (var log in _logs) 
            {
                _logger.Log(log);
            }
            _logs.Clear();
        }
    }

    public void Log(IEnumerable<string> messages)
    {
        _logger.Log(messages);
    }
}

