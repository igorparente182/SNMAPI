using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNMAPI.Domain.Entities
{
    public class WebPush
    {
        public long id { get; set; }

        public APP app { get; set; }

        public string name { get; set; }

        public string address { get; set; }

        public string url_icon { get; set; }

        public string message_text { get; set; }

        public string allow_button_text { get; set; }

        public string deny_button_text { get; set; }

        public string message_title { get; set; }

        public string message_text_welcome { get; set; }

        public string enable_url_redirect { get; set; }

        public string url_redirect { get; set; }


    }
}
