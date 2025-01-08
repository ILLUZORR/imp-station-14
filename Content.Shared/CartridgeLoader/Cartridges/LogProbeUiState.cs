﻿// DV
using Content.Shared._DV.CartridgeLoader.Cartridges;
using Robust.Shared.Serialization;

namespace Content.Shared.CartridgeLoader.Cartridges;

[Serializable, NetSerializable]
public sealed class LogProbeUiState : BoundUserInterfaceState
{
    /// <summary>
    /// The list of probed network devices
    /// </summary>
    public List<PulledAccessLog> PulledLogs;

    /// <summary>
    /// DV: The NanoChat data if a card was scanned, null otherwise
    /// </summary>
    public NanoChatData? NanoChatData { get; }

    public LogProbeUiState(List<PulledAccessLog> pulledLogs, NanoChatData? nanoChatData = null) // DV - NanoChat support
    {
        PulledLogs = pulledLogs;
        NanoChatData = nanoChatData; // DV
    }
}

[Serializable, NetSerializable, DataRecord]
public sealed class PulledAccessLog
{
    public readonly TimeSpan Time;
    public readonly string Accessor;

    public PulledAccessLog(TimeSpan time, string accessor)
    {
        Time = time;
        Accessor = accessor;
    }
}
