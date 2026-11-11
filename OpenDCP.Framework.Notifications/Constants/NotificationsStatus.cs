using System.ComponentModel;

namespace OpenDCP.Framework.Notifications.Constants
{
    public enum NotificationsStatus
    {
        [Description("Active")]
        Active = 1,
        [Description("Deactive")]
        Deactive = 2,
        [Description("On Hold")]
        OnHold = 3
    }
}
