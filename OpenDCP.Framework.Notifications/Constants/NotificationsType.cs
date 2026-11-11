using System.ComponentModel;

namespace OpenDCP.Framework.Notifications.Constants
{
    public enum NotificationsType
    {
        [Description("Notification Single Parameter")]
        NotificationSingleParameter = 1,
        [Description("Notification Equation")]
        NotificationEquation = 2,
        [Description("Notification Model")]
        NotificationModel = 3,
        [Description("Notification ComplianceCheck")]
        NotificationComplianceCheck = 4,
        [Description("Notification Analysis Output")]
        NotificationAnalysisOutput = 5,
        [Description("Notification MetaData Entry")]
        NotificationMetaDataEntry = 6
    }
}
