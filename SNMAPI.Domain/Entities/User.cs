using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNMAPI.Domain.Entities
{
    public class User
    {
        public long id { get; set; }

        public string email { get; set; }

        public string name { get; set; }

        public string company_name { get; set; }

        public string phone_number { get; set; }

        public string company_address { get; set; }

        public string password { get; set; }
    }
}
