using Flunt.Validations;
using SNMAPI.Domain.Commands.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNMAPI.Domain.Commands
{
    public class CreateUserCommand:Contract<CreateUserCommand>,ICommand
    {
        public string email { get; set; }

        public string name { get; set; }

        public string company_name { get; set; }

        public string phone_number { get; set; }

        public string company_address { get; set; }

        public string password { get; set; }

        public void Validate()
        {
            AddNotifications(new Contract<CreateUserCommand>()
                .Requires()
                .IsNotNullOrEmpty(name, "Name is required")
                .IsNotNullOrEmpty(password, "Password is required")
                .IsNotNullOrEmpty(company_name, "Name Company is required")
                );
        }
    }
}
