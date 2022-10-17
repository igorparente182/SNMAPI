using Flunt.Validations;
using SNMAPI.Domain.Commands.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNMAPI.Domain.Commands
{
    public class CreateAPPCommand : Contract<CreateAPPCommand>, ICommand
    {
        public string app_name { get; set; }

        public void Validate()
        {
            AddNotifications(new Contract<CreateAPPCommand>()
                .Requires()
                .IsNotNullOrEmpty(app_name,"Name is required")
                );
        }
    }
}
