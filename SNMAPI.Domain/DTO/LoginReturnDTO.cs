using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNMAPI.Domain.DTO
{
    public class LoginReturnDTO
    {
        public string token { get; set; }

        public UserDTO user { get; set; }
    }
}
