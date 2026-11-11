using System.ComponentModel;

namespace OpenDCP.Framework.Notifications.Constants
{
    public enum BatchMatchingCondition : byte
    {
        [Description("Bad value is detected into JBatchValues column into BatchIntermediate")]
        BadValueIsDetected = 1,
        [Description("Condition match")]
        ConditionMatch = 2,
        [Description("Condition don't match")]
        ConditionDontMatch = 3
    }
}
