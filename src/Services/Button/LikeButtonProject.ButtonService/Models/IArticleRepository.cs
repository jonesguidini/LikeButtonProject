using LikeButtonProject.Core.Data;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LikeButtonProject.ButtonService.Models
{
    public interface IArticleRepository : IRepository<Article>
    {
        Task<IEnumerable<Article>> GetAll();

        Task<int> UpdateLikeCount(Guid articleId);
    }
}
