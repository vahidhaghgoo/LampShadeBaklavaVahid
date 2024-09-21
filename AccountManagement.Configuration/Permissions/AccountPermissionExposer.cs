using _0_Framework.Infrastructure;

namespace AccountManagement.Configuration.Permissions;

public class AccountPermissionExposer : IPermissionExposer
{
    public Dictionary<string, List<PermissionDto>> Expose()
    {
        return new Dictionary<string, List<PermissionDto>>
        {
            {
                "Account", new List<PermissionDto>
                {
                    new(AccountPermissions.ListAccount, "ListAccount"),
                    new(AccountPermissions.SearchAccount, "SearchAccount"),
                    new(AccountPermissions.CreateAccount, "CreateAccount"),
                    new(AccountPermissions.EditAccount, "EditAccount"),
                    new(AccountPermissions.ChangePasswordAccount, "ChangePasswordAccount")
                }
            },
            {
                "Role", new List<PermissionDto>
                {
                    new(AccountPermissions.ListRole, "ListRole"),
                    new(AccountPermissions.SearchRole, "SearchRole"),
                    new(AccountPermissions.CreateRole, "CreateRole"),
                    new(AccountPermissions.EditRole, "EditRole")
                }
            }
        };
    }
}