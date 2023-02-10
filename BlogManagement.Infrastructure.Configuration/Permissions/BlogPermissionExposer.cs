using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _0_Framework.Infrastructure;

namespace BlogManagement.Infrastructure.Configuration.Permissions
{
    public class BlogPermissionExposer : IPermissionExposer
    {
        public Dictionary<string, List<PermissionDto>> Expose()
        {
            return new Dictionary<string, List<PermissionDto>>
            {
                {
                    "ArticleCategories", new List<PermissionDto>
                    {
                        new PermissionDto(BlogPermissions.ListArticleCategories, "ListArticleCategories"),
                        new PermissionDto(BlogPermissions.SearchArticleCategories, "SearchArticleCategories"),
                        new PermissionDto(BlogPermissions.CreateArticleCategories, "CreateArticleCategories"),
                        new PermissionDto(BlogPermissions.EditArticleCategories, "EditArticleCategories"),
                    }
                },
                {
                    "Articles", new List<PermissionDto>
                    {
                        new PermissionDto(BlogPermissions.ListArticles, "ListArticles"),
                        new PermissionDto(BlogPermissions.SearchArticles, "SearchArticles"),
                        new PermissionDto(BlogPermissions.CreateArticles, "CreateArticles"),
                        new PermissionDto(BlogPermissions.EditArticles, "EditArticles"),
                    }
                }
            };
        }
    }
}
