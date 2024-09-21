using System.Collections.Generic;
using _0_Framework.Infrastructure;

namespace ShopManagement.Configuration.Permissions;

public class ShopPermissionExposer : IPermissionExposer
{
    public Dictionary<string, List<PermissionDto>> Expose()
    {
        return new Dictionary<string, List<PermissionDto>>
        {
            {
                "Product", new List<PermissionDto>
                {
                    new(ShopPermissions.ListProducts, "ListProducts"),
                    new(ShopPermissions.SearchProducts, "SearchProducts"),
                    new(ShopPermissions.CreateProduct, "CreateProduct"),
                    new(ShopPermissions.EditProduct, "EditProduct")
                }
            },
            {
                "ProductCategory", new List<PermissionDto>
                {
                    new(ShopPermissions.SearchProductCategories, "SearchProductCategories"),
                    new(ShopPermissions.ListProductCategories, "ListProductCategories"),
                    new(ShopPermissions.CreateProductCategory, "CreateProductCategory"),
                    new(ShopPermissions.EditProductCategory, "EditProductCategory")
                }
            },
            {
                "ProductPicture", new List<PermissionDto>
                {
                    new(ShopPermissions.ListProductPictures, "ListProductPictures"),
                    new(ShopPermissions.SearchProductPictures, "SearchProductPictures"),
                    new(ShopPermissions.CreateProductPictures, "CreateProductPictures"),
                    new(ShopPermissions.EditProductPictures, "EditProductPictures"),
                    new(ShopPermissions.RemoveProductPictures, "RemoveProductPictures"),
                    new(ShopPermissions.RestoreProductPictures, "RestoreProductPictures")
                }
            },
            {
                "Slides", new List<PermissionDto>
                {
                    new(ShopPermissions.ListSlides, "ListSlides"),
                    new(ShopPermissions.SearchSlides, "SearchSlides"),
                    new(ShopPermissions.CreateSlides, "CreateSlides"),
                    new(ShopPermissions.EditSlides, "EditSlides"),
                    new(ShopPermissions.RemoveSlides, "RemoveSlides"),
                    new(ShopPermissions.RestoreSlides, "RestoreSlides")
                }
            },
            {
                "Orders", new List<PermissionDto>
                {
                    new(ShopPermissions.ListOrders, "ListOrders"),
                    new(ShopPermissions.SearchOrders, "SearchOrders"),
                    new(ShopPermissions.ConfirmOrders, "ConfirmOrders"),
                    new(ShopPermissions.CancelOrders, "CancelOrders"),
                    new(ShopPermissions.ItemsOrders, "ItemsOrders")
                }
            }
        };
    }
}