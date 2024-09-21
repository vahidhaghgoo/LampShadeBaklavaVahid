using System.Collections.Generic;
using _0_Framework.Infrastructure;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ShopManagement.Application.Contracts.ProductCategory;
using ShopManagement.Configuration.Permissions;

namespace ServiceHost.Areas.Administration.Pages.Shop.ProductCategories;

[Authorize(Roles = Roles.Administrator)]
public class IndexModel : PageModel
{
    private readonly IProductCategoryApplication _productCategoryApplication;
    public List<ProductCategoryViewModel> ProductCategories;
    public ProductCategorySearchModel SearchModel;

    public IndexModel(IProductCategoryApplication productCategoryApplication)
    {
        _productCategoryApplication = productCategoryApplication;
    }

    [NeedsPermission(ShopPermissions.ListProductCategories)]
    public void OnGet(ProductCategorySearchModel searchModel)
    {
        ProductCategories = _productCategoryApplication.Search(searchModel);
    }

    public IActionResult OnGetCreate()
    {
        return Partial("./Create", new CreateProductCategory());
    }

    [NeedsPermission(ShopPermissions.CreateProductCategory)]
    public JsonResult OnPostCreate(CreateProductCategory command)
    {
        var result = _productCategoryApplication.Create(command);
        return new JsonResult(result);
    }

    public IActionResult OnGetEdit(long id)
    {
        var productCategory = _productCategoryApplication.GetDetails(id);
        return Partial("Edit", productCategory);
    }

    [NeedsPermission(ShopPermissions.EditProductCategory)]
    public JsonResult OnPostEdit(EditProductCategory command)
    {
        var result = _productCategoryApplication.Edit(command);
        return new JsonResult(result);
    }
}