using _0_Framework.Domain;
using ShopManagement.Application.Contracts.Slide2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement.Domain.Slider2Agg
{
    public interface ISlide2Repository :IRepository<long, Slide2>
    {
        EditSlide2 GetDetails(long id);
        List<Slide2ViewModel> Getlist();
    }
}
