 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccountManagement.Application.Contracts.Account;
 using AccountManagement.Application.Contracts.Role;
 using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ShopManagement.Application.Contracts.Product;
using ShopManagement.Application.Contracts.ProductCategory;

 namespace ServiceHost.Areas.Administration.Pages.Accounts.Role
 {
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

         public void OnGet()
         {
             Roles = _roleApplication.List();
         }

        
     }
 }