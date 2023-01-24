namespace DiscountManagement.Application.Contracts.CoustomerDiscount
{
    public class CustomerDiscountSearchModel
    {
        public long Id { get; set; }
        public long ProductId { get; set; }
        public string Product { get; set; }
        public string StartDate { get; set; }

        public string EndDate { get; set; }
    }
}
