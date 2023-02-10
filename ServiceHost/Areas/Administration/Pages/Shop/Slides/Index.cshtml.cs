using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ShopManagement.Application.Contracts.Product;
using ShopManagement.Application.Contracts.ProductPicture;
using ShopManagement.Application.Contracts.Slide;
using System.Collections.Generic;
using _0_Framework.Infrastructure;
using ShopManagement.Configuration.Permissions;

namespace ServiceHost.Areas.Administration.Pages.Shop.Slides
{
    public class IndexModel : PageModel
    {
        [TempData]
        public string Message { get; set; }
        public List<SlideViewModel> Slides;

        private readonly ISlideApplication _slideApplication;
        public IndexModel(ISlideApplication slideApplication)
        {
            _slideApplication = slideApplication;
        }
        [NeedsPermission(ShopPermissions.ListSlides)]

        public void OnGet( )
        {
            Slides = _slideApplication.Getlist();
        }


        public IActionResult OnGetCreate()
        {
            var command = new CreateSlide();
           
            return Partial("./Create", command);
        }

        [NeedsPermission(ShopPermissions.CreateSlides)]

        public JsonResult OnPostCreate(CreateSlide command)
        {
            var result = _slideApplication.Create(command);
            return new JsonResult(result);
        }

        public IActionResult OnGetEdit(long id)
        {
            var slide = _slideApplication.GetDetails(id);
            return Partial("Edit", slide);
        }

        [NeedsPermission(ShopPermissions.EditSlides)]

        public JsonResult OnPostEdit(EditSlide command)
        {
            var result = _slideApplication.Edit(command);
            return new JsonResult(result);
        }

        [NeedsPermission(ShopPermissions.RemoveSlides)]

        public IActionResult OnGetRemove(long id)
        {
            var result = _slideApplication.Remove(id);
            if (result.IsSuccedded)
                return RedirectToPage("./Index");

            Message = result.Message;
            return RedirectToPage("./Index");
        }

        [NeedsPermission(ShopPermissions.RestoreSlides)]

        public IActionResult OnGetRestore(long id)
        {
            var result = _slideApplication.Restore(id);
            if (result.IsSuccedded)
                return RedirectToPage("./Index");

            Message = result.Message;
            return RedirectToPage("./Index");
        }
    }
}
