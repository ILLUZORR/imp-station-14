using Content.Shared._Impstation.CosmicCult.Components;
using Content.Shared.NPC.Prototypes;
using Content.Shared.Roles;
using Content.Shared.Store;
using Robust.Shared.Audio;
using Robust.Shared.Prototypes;
using Robust.Shared.Serialization.TypeSerializers.Implementations.Custom;

namespace Content.Server._Impstation.CosmicCult.Components;

/// <summary>
/// Component for the CosmicCultRuleSystem that should store gameplay info.
/// </summary>
[RegisterComponent, Access(typeof(CosmicCultRuleSystem))]
public sealed partial class CosmicCultRuleComponent : Component
{
    [ViewVariables(VVAccess.ReadOnly)]
    [DataField] public List<EntityUid> Cultists = new();
    [DataField] public bool WinLocked = false;
    [DataField] public WinType WinType = WinType.CrewMinor;
}

// CosmicCultRuleComponent

public enum WinType : byte
{
    /// <summary>
    ///     Cult complete win. The Cosmic Cult beckoned the final curtain call.
    /// </summary>
    CultComplete,
    /// <summary>
    ///    Cult major win. The Monument reached Stage 3 and was fully empowered.
    /// </summary>
    CultMajor,
    /// <summary>
    ///    Cult minor win. Even if the crew escaped, The Monument reached Stage 3.
    /// </summary>
    CultMinor,
    /// <summary>
    ///     Neutral. The Monument didn't reach Stage 3, The crew escaped, but the Cult Leader also escaped.
    /// </summary>
    Neutral,
    /// <summary>
    ///     Crew minor win. The monument didn't reach Stage 3, The crew escaped, and Cult leader was killed, deconverted, or left on the station.
    /// </summary>
    CrewMinor,
    /// <summary>
    ///     Crew major win. The monument didn't reach Stage 3, The crew escaped, and the cult was killed.
    /// </summary>
    CrewMajor,
    /// <summary>
    ///     Crew complete win. The cult was completely deconverted.
    /// </summary>
    CrewComplete,
}
