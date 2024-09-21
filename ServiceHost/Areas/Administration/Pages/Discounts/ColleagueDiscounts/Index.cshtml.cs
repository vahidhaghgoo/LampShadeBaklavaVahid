using System.Collections.Generic;
using _0_Framework.Infrastructure;
using DiscountManagement.Application.Contracts.ColleagueDiscount;
using DiscountManagement.Configuration.Permissions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ShopManagement.Application.Contracts.Product;

namespace ServiceHost.Areas.Administration.Pages.Discounts.ColleagueDiscounts;

[Authorize(Roles = Roles.Administrator)]
public class IndexModel : PageModel
{
    private readonly IColleagueDiscountApplication _colleagueDiscountApplication;

    private readonly IProductApplication _productApplication;
    public List<ColleagueDiscountViewModel> ColleagueDiscounts;
    public SelectList Products;
    public ColleagueDiscountSearchModel SearchModel;

    public IndexModel(IProductApplication productApplication,
        IColleagueDiscountApplication colleagueDiscountApplication)
    {
        _productApplication = productApplication;
        _colleagueDiscountApplication = colleagueDiscountApplication;
    }

    [TempData] public string Message { get; set; }

    [NeedsPermission(DiscountPermissions.ListColleagueDiscounts)]
    public void OnGet(ColleagueDiscountSearchModel searchModel)
    {
        Products = new SelectList(_productApplication.GetProducts(), "Id", "Name");
        ColleagueDiscounts = _colleagueDiscountApplication.Search(searchModel);
    }


    public IActionResult OnGetCreate()
    {
        var command = new DefineColleagueDiscount
        {
            Products = _productApplication.GetProducts()
        };
        return Partial("./Create", command);
    }

    [NeedsPermission(DiscountPermissions.CreateColleagueDiscounts)]
    public JsonResult OnPostCreate(DefineColleagueDiscount command)
    {
        var result = _colleagueDiscountApplication.Define(command);
        return new JsonResult(result);
    }

    public IActionResult OnGetEdit(long id)
    {
        var colleagueDiscount = _colleagueDiscountApplication.GetDetails(id);
        colleagueDiscount.Products = _productApplication.GetProducts();
        return Partial("Edit", colleagueDiscount);
    }

    [NeedsPermission(DiscountPermissions.EditColleagueDiscounts)]
    public JsonResult OnPostEdit(EditColleagueDiscount command)
    {
        var result = _colleagueDiscountApplication.Edit(command);
        return new JsonResult(result);
    }

    [NeedsPermission(DiscountPermissions.RemoveColleagueDiscounts)]
    public IActionResult OnGetRemove(long id)
    {
        _colleagueDiscountApplication.Remove(id);
        return RedirectToPage("./Index");
    }

    [NeedsPermission(DiscountPermissions.RestoreColleagueDiscounts)]
    public IActionResult OnGetRestore(long id)
    {
        _colleagueDiscountApplication.Restore(id);
        return RedirectToPage("./Index");
    }
}