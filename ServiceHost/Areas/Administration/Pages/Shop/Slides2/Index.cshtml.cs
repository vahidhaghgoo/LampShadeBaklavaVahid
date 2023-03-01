using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ShopManagement.Application.Contracts.Slide2;
using System.Collections.Generic;
using _0_Framework.Infrastructure;
using ShopManagement.Configuration.Permissions;

namespace ServiceHost.Areas.Administration.Pages.Shop.Slides2
{
    public class IndexModel : PageModel
    {
        [TempData]
        public string Message { get; set; }
        public List<Slide2ViewModel> Slides2;

        private readonly ISlide2Application _slide2Application;
        public IndexModel(ISlide2Application slide2Application)
        {
            _slide2Application = slide2Application;
        }
        //[NeedsPermission(ShopPermissions.ListSlides)]

        public void OnGet( )
        {
            Slides2 = _slide2Application.Getlist();
        }


        public IActionResult OnGetCreate()
        {
            var command = new CreateSlide2();
           
            return Partial("./Create", command);
        }

        //[NeedsPermission(ShopPermissions.CreateSlides)]

        public JsonResult OnPostCreate(CreateSlide2 command)
        {
            var result = _slide2Application.Create(command);
            return new JsonResult(result);
        }

        public IActionResult OnGetEdit(long id)
        {
            var slide = _slide2Application.GetDetails(id);
            return Partial("Edit", slide);
        }

        //[NeedsPermission(ShopPermissions.EditSlides)]

        public JsonResult OnPostEdit(EditSlide2 command)
        {
            var result = _slide2Application.Edit(command);
            return new JsonResult(result);
        }

        //[NeedsPermission(ShopPermissions.RemoveSlides)]

        public IActionResult OnGetRemove(long id)
        {
            var result = _slide2Application.Remove(id);
            if (result.IsSuccedded)
                return RedirectToPage("./Index");

            Message = result.Message;
            return RedirectToPage("./Index");
        }

        //[NeedsPermission(ShopPermissions.RestoreSlides)]

        public IActionResult OnGetRestore(long id)
        {
            var result = _slide2Application.Restore(id);
            if (result.IsSuccedded)
                return RedirectToPage("./Index");

            Message = result.Message;
            return RedirectToPage("./Index");
        }
    }
}
