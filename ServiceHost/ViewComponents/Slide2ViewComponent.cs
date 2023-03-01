using _01_LampshadeQuery.Contracts.Slide2;
using Microsoft.AspNetCore.Mvc;

namespace ServiceHost.ViewComponents
{
    public class Slide2ViewComponent : ViewComponent
    {
        private readonly ISlide2Query _slide2Query;

        public Slide2ViewComponent(ISlide2Query slide2Query)
        {
            _slide2Query = slide2Query;

        }
        public IViewComponentResult Invoke()
        {
            var slides = _slide2Query.GetSlides();
            return View(slides);
        }
    }
}
