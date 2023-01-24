namespace InventoryManagement.Application.Contract.Inventory
{
    public class ReduseInventory
    {
        public long InventoryId { get; set; }
        public long ProductId { get; set; }
        public long Count { get; set; }

        public string Description { get; set; }

        public long OrderId { get; set; }

        public ReduseInventory()
        {
           
        }

        public ReduseInventory(long productId,long count,string description,long orderId)
        {
            ProductId = productId;
            Count = count;
            Description = description;
            OrderId=orderId;
        }
    }
}
