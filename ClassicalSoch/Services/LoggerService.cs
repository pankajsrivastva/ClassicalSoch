using ClassicalSoch.Interfaces;

namespace ClassicalSoch.Services;

public class LoggerService : ILoggerService
{
    private readonly string _logPath;

    public LoggerService()
    {
        _logPath = Path.Combine(AppContext.BaseDirectory, "logs", "application.log");
        Directory.CreateDirectory(Path.GetDirectoryName(_logPath)!);
    }

    public void LogInformation(string message)
    {
        AppendLog("INFO", message);
    }

    public void LogError(string message, Exception? exception = null)
    {
        AppendLog("ERROR", message + (exception is null ? string.Empty : $" | {exception.Message}"));
    }

    private void AppendLog(string level, string message)
    {
        var line = $"[{DateTimeOffset.UtcNow:O}] [{level}] {message}{Environment.NewLine}";
        File.AppendAllText(_logPath, line);
    }
}
