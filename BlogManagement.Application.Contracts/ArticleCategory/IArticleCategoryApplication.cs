﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _0_Framework.Application;

namespace BlogManagement.Application.Contracts.ArticleCategory
{
    public interface IArticleCategoryApplication
    {
        OperationResult Create(CreateArticleCategory command);
        OperationResult Edit(EditArticleCategory command);
        EditArticleCategory GetDetails(long id);
        List<ArticleCategoryViewModel> GetArticleCategories();
        List<ArticleCategoryViewModel> Search(ArticleCategorySearchModel searchModel);
    }
}
