 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
 using _0_Framework.Infrastructure;
 using AccountManagement.Application.Contracts.Account;
 using AccountManagement.Application.Contracts.Role;
 using AccountManagement.Configuration.Permissions;
 using BlogManagement.Infrastructure.Configuration.Permissions;
 using Microsoft.AspNetCore.Authorization;
 using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ShopManagement.Application.Contracts.Product;
using ShopManagement.Application.Contracts.ProductCategory;

 namespace ServiceHost.Areas.Administration.Pages.Accounts.Role
 {
     //[Authorize(Roles = _0_Framework.Infrastructure.Roles.Administrator)]
     public class IndexModel : PageModel
     {
         [TempData]
         public string Message { get; set; }
         public List<RoleViewModel> Roles;

         private readonly IRoleApplication _roleApplication;

         public IndexModel(IRoleApplication roleApplication)
         {
             _roleApplication = roleApplication;
         }

         [NeedsPermission(AccountPermissions.ListRole)]

        public void OnGet()
         {
             Roles = _roleApplication.List();
         }

        
     }
 }