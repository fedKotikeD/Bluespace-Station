using System.Threading;
using Content.Shared.Actions.ActionTypes;
using Robust.Shared.Utility;

namespace Content.Server.Medical.Components
{
    /// <summary>
    /// Adds an innate verb when equipped to use a stethoscope.
    /// </summary>
    [RegisterComponent]
    public sealed partial class StethoscopeComponent : Component
    {
        public bool IsActive = false;

        [DataField("delay")]
        public float Delay = 2.5f;

        public EntityTargetAction Action = new()
        {
            Icon = new SpriteSpecifier.Texture(new ("Clothing/Neck/Misc/stethoscope.rsi/icon.png")),
            DisplayName = "stethoscope-verb",
            Priority = -1,
            Event = new StethoscopeActionEvent(),
        };
    }
}
