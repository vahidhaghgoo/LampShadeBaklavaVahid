using _0_Framework.Application;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagement.Application.Contracts.Account
{
    public class Login
    {
        
        //[Required(ErrorMessage = ValidationMessages.IsRequired)]

        public string Username { get; set; }

        //[Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Password { get; set; }
    }
}
