﻿using MB.Infrastructure.Query;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Master_Blogger.Pages
{
    public class ArticleDetailsModel : PageModel
    {
        public ArticleQueryView Article { get; set; }

        private readonly IArticleQuery _articleQuery;

        public ArticleDetailsModel(IArticleQuery articleQuery)
        {
            _articleQuery = articleQuery;
        }

        public void OnGet(long id)
        {
            Article = _articleQuery.GetArticle(id);
        }

    }
}