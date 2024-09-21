using System.Collections.Generic;

namespace _01_LampshadeQuery.Contracts.Slide2;

public interface ISlide2Query
{
    List<Slide2QueryModel> GetSlides();
}