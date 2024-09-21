using System.Collections.Generic;
using _0_Framework.Infrastructure;
using AccountManagement.Application.Contracts.Role;
using AccountManagement.Configuration.Permissions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Areas.Administration.Pages.Accounts.Role;

//[Authorize(Roles = _0_Framework.Infrastructure.Roles.Administrator)]
public class IndexModel : PageModel
{
    private readonly IRoleApplication _roleApplication;
    public List<RoleViewModel> Roles;

    public IndexModel(IRoleApplication roleApplication)
    {
        _roleApplication = roleApplication;
    }

    [TempData] public string Message { get; set; }

    [NeedsPermission(AccountPermissions.ListRole)]
    public void OnGet()
    {
        Roles = _roleApplication.List();
    }
}