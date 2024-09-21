using System.Collections.Generic;
using _0_Framework.Domain;
using ShopManagement.Application.Contracts.Slide2;

namespace ShopManagement.Domain.Slider2Agg;

public interface ISlide2Repository : IRepository<long, Slide2>
{
    EditSlide2 GetDetails(long id);
    List<Slide2ViewModel> Getlist();
}