using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _0_Framework.Infrastructure;

namespace CommentManagement.Infrastructure.Configuration.Permissions
{
    public class CommentPermissionExposer : IPermissionExposer
    {
        public Dictionary<string, List<PermissionDto>> Expose()
        {
            return new Dictionary<string, List<PermissionDto>>
            {
                {
                    "Comments", new List<PermissionDto>
                    {
                        new PermissionDto(CommentPermissions.ListComments, "ListComments"),
                        new PermissionDto(CommentPermissions.SearchComments, "SearchComments"),
                        new PermissionDto(CommentPermissions.ConfirmComments, "ConfirmComments"),
                        new PermissionDto(CommentPermissions.CancelComments, "CancelComments")
                    }
                }
            };
        }
    }
}
