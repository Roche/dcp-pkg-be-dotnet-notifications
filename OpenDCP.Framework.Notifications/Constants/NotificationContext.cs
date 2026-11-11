using System.ComponentModel;

namespace OpenDCP.Framework.Notifications.Constants
{
    public enum NotificationContext
    {
        [Description("Continuous")]
        Continuous = 1,
        [Description("Batch")]
        Batch = 2
    }
}
