using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNMAPI.Domain.Entities
{
    public class APP
    {
        public long app_id { get; set; }

        public string app_name { get; set; }

        public string app_token { get; set; }

        public bool webpush { get; set; }

        public bool email { get; set; }

        public bool sms { get; set; }

    }
}
