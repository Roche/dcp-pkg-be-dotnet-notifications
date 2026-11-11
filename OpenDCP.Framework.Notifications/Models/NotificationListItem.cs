using System;

namespace OpenDCP.Framework.Notifications.Models
{
    public class NotificationListItem
    {
        public Guid ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public byte Status { get; set; }
        public byte Type { get; set; }
        public byte NotificationContext { get; set; }
        public bool IsValidated { get; set; }
        public string Module { get; set; }
        public string Label { get; set; }
        public string LabelBackground { get; set; }
        public bool ShowHoldState { get; set; }
        public string EditUrl { get; set; }
    }
}
