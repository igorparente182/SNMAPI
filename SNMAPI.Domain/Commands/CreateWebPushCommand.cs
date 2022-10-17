using Flunt.Validations;
using SNMAPI.Domain.Commands.Contracts;
using SNMAPI.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNMAPI.Domain.Commands
{
    public class CreateWebPushCommand : Contract<CreateWebPushCommand>, ICommand
    {
        public WebPushSettingDTO settings { get; set; }

        public void Validate()
        {
            
        }
    }
}
