using _0_Framework.Infrastructure;

namespace CommentManagement.Infrastructure.Configuration.Permissions;

public class CommentPermissionExposer : IPermissionExposer
{
    public Dictionary<string, List<PermissionDto>> Expose()
    {
        return new Dictionary<string, List<PermissionDto>>
        {
            {
                "Comments", new List<PermissionDto>
                {
                    new(CommentPermissions.ListComments, "ListComments"),
                    new(CommentPermissions.SearchComments, "SearchComments"),
                    new(CommentPermissions.ConfirmComments, "ConfirmComments"),
                    new(CommentPermissions.CancelComments, "CancelComments")
                }
            }
        };
    }
}