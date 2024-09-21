using System.Collections.Generic;
using System.Linq;
using _0_Framework.Application;
using _0_Framework.Infrastructure;
using ShopManagement.Application.Contracts.Slide2;
using ShopManagement.Domain.Slider2Agg;

namespace ShopManagement.Infrastructure.EFCore.Repository;

public class Slide2Repository : RepositoryBase<long, Slide2>, ISlide2Repository
{
    private readonly ShopContext _context;

    public Slide2Repository(ShopContext context) : base(context)
    {
        _context = context;
    }

    public EditSlide2 GetDetails(long id)
    {
        return _context.Slide.Select(x => new EditSlide2
        {
            Id = x.Id,
            BtnText = x.BtnText,
            PictureAlt = x.PictureAlt,
            PictureTitle = x.PictureTitle,
            Text = x.Text,
            Link = x.Link,
            Title = x.Title
        }).FirstOrDefault(x => x.Id == id);
    }

    public List<Slide2ViewModel> Getlist()
    {
        return _context.Slide2.Select(x => new Slide2ViewModel
        {
            Id = x.Id,
            Picture = x.Picture,
            Title = x.Title,
            IsRemoved = x.IsRemoved,
            CreationDate = x.CreationDate.ToFarsi()
        }).OrderByDescending(x => x.Id).ToList();
    }
}