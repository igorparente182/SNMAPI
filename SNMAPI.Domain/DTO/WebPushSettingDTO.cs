using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNMAPI.Domain.DTO
{
    public class WebPushSettingDTO
    {
        public WEbPushSiteDTO site { get; set; }

        public WebPushAllowNotificationDTO allow_notification { get; set; }

        public WebPushWelcomeNotificationDTO welcome_notification { get; set; }
    }
}
