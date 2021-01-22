using LikeButtonProject.ButtonService.Models;
using LikeButtonProject.Core.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LikeButtonProject.ButtonService.Data.Repository
{
    public class ArticleRepository : IArticleRepository
    {
        private readonly DataContext _context;

        public ArticleRepository(DataContext context)
        {
            _context = context;
        }

        public IUnitOfWork UnitOfWork => _context;

        public async Task<IEnumerable<Article>> GetAll()
        {
            return await _context.Articles.OrderBy(x => x.Title).ToListAsync();
        }

        public async Task<int> UpdateLikeCount(Guid articleId)
        {
            var article = await _context.Articles.FirstOrDefaultAsync(x => x.Id == articleId);

            if (article == null)
                return 0;

            article.UpdateLikesCount();

            _context.Articles.Update(article);

            await _context.Commit();

            return article.LikesCount;
        }

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}
