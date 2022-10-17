using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNMAPI.Domain.DTO
{
    public class WebPushAllowNotificationDTO
    {
        public string message_text { get; set; }

        public string allow_button_text { get; set; }

        public string deny_button_text { get; set; }
    }
}
