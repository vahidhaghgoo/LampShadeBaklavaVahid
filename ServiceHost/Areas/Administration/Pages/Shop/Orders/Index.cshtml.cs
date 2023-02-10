using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _0_Framework.Infrastructure;
using AccountManagement.Application.Contracts.Account;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ShopManagement.Application.Contracts.Order;
using ShopManagement.Application.Contracts.ProductCategory;
using ShopManagement.Configuration.Permissions;

namespace ServiceHost.Areas.Administration.Pages.Shop.Orders
{
    public class IndexModel : PageModel
    {
        public OrderSearchModel SearchModel;
        public SelectList Accounts;
        public List<OrderViewModel> Orders;

        private readonly IOrderApplication _orderApplication;
        private readonly IAccountApplication _accountApplication;

        public IndexModel(IOrderApplication orderApplication, IAccountApplication accountApplication)
        {
            _orderApplication = orderApplication;
            _accountApplication = accountApplication;
        }

        [NeedsPermission(ShopPermissions.ListOrders)]

        public void OnGet(OrderSearchModel searchModel)
        {
            Accounts = new SelectList(_accountApplication.GetAccounts(), "Id", "Fullname");
            Orders = _orderApplication.Search(searchModel);
        }

        [NeedsPermission(ShopPermissions.ConfirmOrders)]

        public IActionResult OnGetConfirm(long id)
        {
            _orderApplication.PaymentSucceeded(id, 0);
            return RedirectToPage("./Index");
        }

        [NeedsPermission(ShopPermissions.CancelOrders)]

        public IActionResult OnGetCancel(long id)
        {
            _orderApplication.Cancel(id);
            return RedirectToPage("./Index");
        }

        [NeedsPermission(ShopPermissions.ItemsOrders)]

        public IActionResult OnGetItems(long id)
        {
            var items = _orderApplication.GetItems(id);
            return Partial("Items", items);
        }
    }
}