using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNMAPI.Domain.Commands
{
    public class UpdateAPPCommand:CreateAPPCommand
    {
        public long app_id { get; set; }
    }
}
