using System.Collections.Generic;
using _0_Framework.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ShopManagement.Application.Contracts.Product;
using ShopManagement.Application.Contracts.ProductPicture;
using ShopManagement.Configuration.Permissions;

namespace ServiceHost.Areas.Administration.Pages.Shop.ProductPictures;

public class IndexModel : PageModel
{
    private readonly IProductApplication _productApplication;
    private readonly IProductPictureApplication _productPictureApplication;
    public List<ProductPictureViewModel> ProductPictures;
    public SelectList Products;
    public ProductPictureSearchModel SearchModel;

    public IndexModel(IProductApplication productApplication, IProductPictureApplication productPictureApplication)
    {
        _productApplication = productApplication;
        _productPictureApplication = productPictureApplication;
    }

    [TempData] public string Message { get; set; }

    [NeedsPermission(ShopPermissions.ListProductPictures)]
    public void OnGet(ProductPictureSearchModel searchModel)
    {
        Products = new SelectList(_productApplication.GetProducts(), "Id", "Name");
        ProductPictures = _productPictureApplication.Search(searchModel);
    }

    public IActionResult OnGetCreate()
    {
        var command = new CreateProductPicture
        {
            Products = _productApplication.GetProducts()
        };
        return Partial("./Create", command);
    }

    [NeedsPermission(ShopPermissions.CreateProductPictures)]
    public JsonResult OnPostCreate(CreateProductPicture command)
    {
        var result = _productPictureApplication.Create(command);
        return new JsonResult(result);
    }

    public IActionResult OnGetEdit(long id)
    {
        var productPicture = _productPictureApplication.GetDetails(id);
        productPicture.Products = _productApplication.GetProducts();
        return Partial("Edit", productPicture);
    }

    [NeedsPermission(ShopPermissions.EditProductPictures)]
    public JsonResult OnPostEdit(EditProductPicture command)
    {
        var result = _productPictureApplication.Edit(command);
        return new JsonResult(result);
    }

    [NeedsPermission(ShopPermissions.RemoveProductPictures)]
    public IActionResult OnGetRemove(long id)
    {
        var result = _productPictureApplication.Remove(id);
        if (result.IsSuccedded)
            return RedirectToPage("./Index");

        Message = result.Message;
        return RedirectToPage("./Index");
    }

    [NeedsPermission(ShopPermissions.RestoreProductPictures)]
    public IActionResult OnGetRestore(long id)
    {
        var result = _productPictureApplication.Restore(id);
        if (result.IsSuccedded)
            return RedirectToPage("./Index");

        Message = result.Message;
        return RedirectToPage("./Index");
    }
}