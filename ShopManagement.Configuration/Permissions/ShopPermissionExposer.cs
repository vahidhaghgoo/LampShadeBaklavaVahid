using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _0_Framework.Infrastructure;

namespace ShopManagement.Configuration.Permissions
{
    public class ShopPermissionExposer : IPermissionExposer
    {
        public Dictionary<string, List<PermissionDto>> Expose()
        {
            return new Dictionary<string, List<PermissionDto>>
            {
                {
                    "Product", new List<PermissionDto>
                    {
                        new PermissionDto(ShopPermissions.ListProducts, "ListProducts"),
                        new PermissionDto(ShopPermissions.SearchProducts, "SearchProducts"),
                        new PermissionDto(ShopPermissions.CreateProduct, "CreateProduct"),
                        new PermissionDto(ShopPermissions.EditProduct, "EditProduct"),
                    }
                },
                {
                    "ProductCategory", new List<PermissionDto>
                    {
                        new PermissionDto(ShopPermissions.SearchProductCategories, "SearchProductCategories"),
                        new PermissionDto(ShopPermissions.ListProductCategories, "ListProductCategories"),
                        new PermissionDto(ShopPermissions.CreateProductCategory, "CreateProductCategory"),
                        new PermissionDto(ShopPermissions.EditProductCategory, "EditProductCategory"),
                    }

                },
                {
                "ProductPicture", new List<PermissionDto>
                {
                    new PermissionDto(ShopPermissions.ListProductPictures, "ListProductPictures"),
                    new PermissionDto(ShopPermissions.SearchProductPictures, "SearchProductPictures"),
                    new PermissionDto(ShopPermissions.CreateProductPictures, "CreateProductPictures"),
                    new PermissionDto(ShopPermissions.EditProductPictures, "EditProductPictures"),
                    new PermissionDto(ShopPermissions.RemoveProductPictures, "RemoveProductPictures"),
                    new PermissionDto(ShopPermissions.RestoreProductPictures, "RestoreProductPictures"),

                }
            },
                {
                "Slides", new List<PermissionDto>
                {
                    new PermissionDto(ShopPermissions.ListSlides, "ListSlides"),
                    new PermissionDto(ShopPermissions.SearchSlides, "SearchSlides"),
                    new PermissionDto(ShopPermissions.CreateSlides, "CreateSlides"),
                    new PermissionDto(ShopPermissions.EditSlides, "EditSlides"),
                    new PermissionDto(ShopPermissions.RemoveSlides, "RemoveSlides"),
                    new PermissionDto(ShopPermissions.RestoreSlides, "RestoreSlides"),

                }
                },
                {
                    "Orders", new List<PermissionDto>
                    {
                        new PermissionDto(ShopPermissions.ListOrders, "ListOrders"),
                        new PermissionDto(ShopPermissions.SearchOrders, "SearchOrders"),
                        new PermissionDto(ShopPermissions.ConfirmOrders, "ConfirmOrders"),
                        new PermissionDto(ShopPermissions.CancelOrders, "CancelOrders"),
                        new PermissionDto(ShopPermissions.ItemsOrders, "ItemsOrders"),

                    }
                }
            };
        }
    }
}
