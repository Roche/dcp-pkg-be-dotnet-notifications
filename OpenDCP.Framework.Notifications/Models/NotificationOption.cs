using System.Collections.Generic;

namespace OpenDCP.Framework.Notifications.Models
{
    public class NotificationOption
    {
        /// <summary>
        /// The list of permission identifiers required for this notification option to be available or visible to a user.
        /// </summary>
        public List<string> Permissions { get; set; }

        /// <summary>
        /// The display label shown to the user for this notification option.
        /// </summary>
        public string Label { get; set; }

        /// <summary>
        /// The type of the notification option, used to determine how it should be handled or rendered.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// The URL associated with this notification option.
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// A value indicating whether actions related to this notification option should be recorded for auditing purposes.
        /// </summary>
        public bool IsAuditable { get; set; }
    }
}
