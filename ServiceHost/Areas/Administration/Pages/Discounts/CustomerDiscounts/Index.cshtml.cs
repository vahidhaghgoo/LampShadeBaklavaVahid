using System.Collections.Generic;
using _0_Framework.Infrastructure;
using DiscountManagement.Application.Contracts.CoustomerDiscount;
using DiscountManagement.Configuration.Permissions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ShopManagement.Application.Contracts.Product;

namespace ServiceHost.Areas.Administration.Pages.Discounts.CustomerDiscounts;

public class IndexModel : PageModel
{
    private readonly ICustomerDiscountApplication _customerDiscountApplication;

    private readonly IProductApplication _productApplication;
    public List<CustomerDiscountViewModel> CustomerDiscounts;
    public SelectList Products;
    public CustomerDiscountSearchModel SearchModel;

    public IndexModel(IProductApplication productApplication, ICustomerDiscountApplication customerDiscountApplication)
    {
        _productApplication = productApplication;
        _customerDiscountApplication = customerDiscountApplication;
    }

    [TempData] public string Message { get; set; }

    [NeedsPermission(DiscountPermissions.ListCustomerDiscounts)]
    public void OnGet(CustomerDiscountSearchModel searchModel)
    {
        Products = new SelectList(_productApplication.GetProducts(), "Id", "Name");
        CustomerDiscounts = _customerDiscountApplication.Search(searchModel);
    }

    public IActionResult OnGetCreate()
    {
        var command = new DefineCustomerDiscount
        {
            Products = _productApplication.GetProducts()
        };
        return Partial("./Create", command);
    }

    [NeedsPermission(DiscountPermissions.CreateCustomerDiscounts)]
    public JsonResult OnPostCreate(DefineCustomerDiscount command)
    {
        var result = _customerDiscountApplication.Define(command);
        return new JsonResult(result);
    }

    public IActionResult OnGetEdit(long id)
    {
        var customerDiscount = _customerDiscountApplication.GetDetails(id);
        customerDiscount.Products = _productApplication.GetProducts();
        return Partial("Edit", customerDiscount);
    }

    [NeedsPermission(DiscountPermissions.EditCustomerDiscounts)]
    public JsonResult OnPostEdit(EditCustomerDiscount command)
    {
        var result = _customerDiscountApplication.Edit(command);
        return new JsonResult(result);
    }
}