using _0_Framework.Infrastructure;

namespace BlogManagement.Infrastructure.Configuration.Permissions;

public class BlogPermissionExposer : IPermissionExposer
{
    public Dictionary<string, List<PermissionDto>> Expose()
    {
        return new Dictionary<string, List<PermissionDto>>
        {
            {
                "ArticleCategories", new List<PermissionDto>
                {
                    new(BlogPermissions.ListArticleCategories, "ListArticleCategories"),
                    new(BlogPermissions.SearchArticleCategories, "SearchArticleCategories"),
                    new(BlogPermissions.CreateArticleCategories, "CreateArticleCategories"),
                    new(BlogPermissions.EditArticleCategories, "EditArticleCategories")
                }
            },
            {
                "Articles", new List<PermissionDto>
                {
                    new(BlogPermissions.ListArticles, "ListArticles"),
                    new(BlogPermissions.SearchArticles, "SearchArticles"),
                    new(BlogPermissions.CreateArticles, "CreateArticles"),
                    new(BlogPermissions.EditArticles, "EditArticles")
                }
            }
        };
    }
}