namespace ShopManagement.Application.Contracts.Slide2;

public class Slide2ViewModel
{
    public long Id { set; get; }
    public string Picture { get; set; }
    public string Title { get; set; }
    public bool IsRemoved { get; set; }
    public string CreationDate { get; set; }
}