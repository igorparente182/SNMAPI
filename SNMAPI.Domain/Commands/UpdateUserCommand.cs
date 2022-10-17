using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNMAPI.Domain.Commands
{
    public class UpdateUserCommand:CreateUserCommand
    {
        public long Id { get; set; }

    }
}
