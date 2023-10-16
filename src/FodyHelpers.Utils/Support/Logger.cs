﻿namespace FodyHelpers.Utils.Support;

public class Logger : ILogger
{
    private readonly BaseModuleWeaver _moduleWeaver;

    public Logger(BaseModuleWeaver moduleWeaver)
        => _moduleWeaver = moduleWeaver;

    public void Debug(string message)
        => _moduleWeaver.WriteDebug(message);

    public void Info(string message)
        => _moduleWeaver.WriteInfo(message);

    public void Warning(string message, SequencePoint? sequencePoint)
        => _moduleWeaver.WriteWarning(message, sequencePoint);

    public void Error(string message, SequencePoint? sequencePoint)
        => _moduleWeaver.WriteError(message, sequencePoint);
}
