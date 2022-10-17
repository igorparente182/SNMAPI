using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNMAPI.Domain.DTO
{
    public class WebPushWelcomeNotificationDTO
    {
        public string message_title { get; set; }

        public string message_text { get; set; }

        public string enable_url_redirect { get; set; }

        public string url_redirect { get; set; }
    }
}
