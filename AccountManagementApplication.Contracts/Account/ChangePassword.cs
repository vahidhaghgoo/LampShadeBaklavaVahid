using _0_Framework.Application;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagement.Application.Contracts.Account
{
    public class ChangePassword
    {
        public long Id { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]

        public string Password { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]

        public string RePassword { get; set; }
    }
}
