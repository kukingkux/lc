using System;
using System.IO;
using BepInEx.Logging;

public class CrashSafeLogger : ILogListener
{
    private StreamWriter _writer;

    public CrashSafeLogger(string filePath)
    {
        // FileShare.Read allows you to open the text file while the game is running
        var fileStream = new FileStream(filePath, FileMode.Append, FileAccess.Write, FileShare.Read);
        _writer = new StreamWriter(fileStream)
        {
            AutoFlush = true // Forces immediate hardware write
        };
        AppDomain.CurrentDomain.UnhandledException += OnUnhandledException;
    }

    public void LogEvent(object sender, LogEventArgs eventArgs)
    {
        _writer.WriteLine($"[{DateTime.Now:HH:mm:ss.fff}] [{eventArgs.Level}] {eventArgs.Data}");
    }

    private void OnUnhandledException(object sender, UnhandledExceptionEventArgs e)
    {
        _writer.WriteLine($"[FATAL DOMAIN CRASH] {e.ExceptionObject}");
        _writer.Flush(); 
    }

    public void Dispose()
    {
        AppDomain.CurrentDomain.UnhandledException -= OnUnhandledException;
        _writer?.Dispose();
    }
}