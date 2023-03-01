using _01_LampshadeQuery.Contracts.Slide2;
using ShopManagement.Infrastructure.EFCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_LampshadeQuery.Query
{
    public class Slide2Query : ISlide2Query
    {
        private readonly ShopContext _shopContext;

        public Slide2Query(ShopContext shopContext)
        {
            _shopContext = shopContext;
        }
        public List<Slide2QueryModel> GetSlides()
        {
            return _shopContext.Slide2.Where(x => x.IsRemoved == false)
                .Select(x => new Slide2QueryModel
                {
                    Picture = x.Picture,
                    PictureAlt = x.PictureAlt,
                    PictureTitle = x.PictureTitle,
                    BtnText = x.BtnText,
                    Link = x.Link,
                    Text = x.Text,
                    Title = x.Title

                }).ToList();

        }
    }
}
