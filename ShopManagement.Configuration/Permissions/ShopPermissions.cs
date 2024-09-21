namespace ShopManagement.Configuration.Permissions;

public static class ShopPermissions
{
    //Product
    public const int ListProducts = 10;
    public const int SearchProducts = 11;
    public const int CreateProduct = 12;
    public const int EditProduct = 13;


    //ProductCategory
    public const int ListProductCategories = 20;
    public const int SearchProductCategories = 21;
    public const int CreateProductCategory = 22;
    public const int EditProductCategory = 23;

    //ProductPicture
    public const int ListProductPictures = 30;
    public const int SearchProductPictures = 31;
    public const int CreateProductPictures = 32;
    public const int EditProductPictures = 33;
    public const int RemoveProductPictures = 34;
    public const int RestoreProductPictures = 35;

    //Slides
    public const int ListSlides = 40;
    public const int SearchSlides = 41;
    public const int CreateSlides = 42;
    public const int EditSlides = 43;
    public const int RemoveSlides = 44;
    public const int RestoreSlides = 45;

    //Orders
    public const int ListOrders = 60;
    public const int SearchOrders = 61;
    public const int ConfirmOrders = 62;
    public const int CancelOrders = 63;
    public const int ItemsOrders = 64;
}