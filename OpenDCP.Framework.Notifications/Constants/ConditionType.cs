using System.ComponentModel;

namespace OpenDCP.Framework.Notifications.Constants
{
    public enum ConditionType : byte
    {
        [Description("Is equal")]
        IsEqual = 1,

        [Description("Is not equal")]
        IsNotEqual = 2,

        [Description("Greater than")]
        GreaterThan = 3,

        [Description("Greater than or equal")]
        GreaterThanOrEqual = 4,

        [Description("Less than")]
        LessThan = 5,

        [Description("Less than or equal")]
        LessThanOrEqual = 6,

        [Description("Within")]
        Within = 7,

        [Description("Outside")]
        Outside = 8
    }
}
