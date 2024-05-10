using System;

static class LogLine
{
    public static string Message(string logLine)
    {
            int colonIndex = logLine.IndexOf(':');
    
    string message = logLine.Substring(colonIndex + 1).Trim();
        return message;
        throw new NotImplementedException("Please implement the (static) LogLine.Message() method");
    }

    public static string LogLevel(string logLine)
    {
         int from = logLine.IndexOf('[');
    int to = logLine.IndexOf(']');

    return logLine.Substring(from + 1, to - from - 1).ToLower();
        throw new NotImplementedException("Please implement the (static) LogLine.LogLevel() method");
    }

    public static string Reformat(string logLine)
    {
    int colonIndex = logLine.IndexOf(':');
    string logLevel = logLine.Substring(1, colonIndex - 2).ToLower(); 
    string message = logLine.Substring(colonIndex + 1).Trim(); 
    
    return $"{message} ({logLevel})";
        throw new NotImplementedException("Please implement the (static) LogLine.Reformat() method");
    }
}
