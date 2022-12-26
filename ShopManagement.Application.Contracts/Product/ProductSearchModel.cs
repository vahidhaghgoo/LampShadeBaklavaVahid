namespace ShopManagement.Application.Contracts.Product
{
    public class ProductSearchModel
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public long Id { get; set; }
        public long CategoryId { get; set; }
    }
}
