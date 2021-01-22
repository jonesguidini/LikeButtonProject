using LikeButtonProject.MVC.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LikeButtonProject.MVC.services
{
    public interface IArticleService
    {
        Task<IEnumerable<ArticleViewModel>> GetAll();
        Task<int> AddLikeArticle(Guid articleId, string userIP);
    }
}
