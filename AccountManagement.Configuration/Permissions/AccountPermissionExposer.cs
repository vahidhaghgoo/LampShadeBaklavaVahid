using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _0_Framework.Infrastructure;

namespace AccountManagement.Configuration.Permissions
{
    public class AccountPermissionExposer : IPermissionExposer
    {
        public Dictionary<string, List<PermissionDto>> Expose()
        {
            return new Dictionary<string, List<PermissionDto>>
            {
                {
                    "Account", new List<PermissionDto>
                    {
                        new PermissionDto(AccountPermissions.ListAccount, "ListAccount"),
                        new PermissionDto(AccountPermissions.SearchAccount, "SearchAccount"),
                        new PermissionDto(AccountPermissions.CreateAccount, "CreateAccount"),
                        new PermissionDto(AccountPermissions.EditAccount, "EditAccount"),
                        new PermissionDto(AccountPermissions.ChangePasswordAccount, "ChangePasswordAccount"),

                    }
                },
                {
                    "Role", new List<PermissionDto>
                    {
                        new PermissionDto(AccountPermissions.ListRole, "ListRole"),
                        new PermissionDto(AccountPermissions.SearchRole, "SearchRole"),
                        new PermissionDto(AccountPermissions.CreateRole, "CreateRole"),
                        new PermissionDto(AccountPermissions.EditRole, "EditRole"),
                    }
                }
            };
        }
    }
}
