using System.Collections.Generic;
using _0_Framework.Infrastructure;
using CommentManagement.Application.Contracts.Comment;
using CommentManagement.Infrastructure.Configuration.Permissions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Areas.Administration.Pages.Comments;

public class IndexModel : PageModel
{
    private readonly ICommentApplication _commentApplication;
    public List<CommentViewModel> Comments;
    public CommentSearchModel SearchModel;

    public IndexModel(ICommentApplication commentApplication)
    {
        _commentApplication = commentApplication;
    }

    [TempData] public string Message { get; set; }

    [NeedsPermission(CommentPermissions.ListComments)]
    public void OnGet(CommentSearchModel searchModel)
    {
        Comments = _commentApplication.Search(searchModel);
    }

    [NeedsPermission(CommentPermissions.CancelComments)]
    public IActionResult OnGetCancel(long id)
    {
        var result = _commentApplication.Cancel(id);
        if (result.IsSuccedded)
            return RedirectToPage("./Index");

        Message = result.Message;
        return RedirectToPage("./Index");
    }

    [NeedsPermission(CommentPermissions.ConfirmComments)]
    public IActionResult OnGetConfirm(long id)
    {
        var result = _commentApplication.Confirm(id);
        if (result.IsSuccedded)
            return RedirectToPage("./Index");

        Message = result.Message;
        return RedirectToPage("./Index");
    }
}