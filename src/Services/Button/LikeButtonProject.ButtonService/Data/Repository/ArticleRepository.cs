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
            return await _context.Articles.Include(x => x.Like).OrderBy(x => x.Title).ToListAsync();
        }

        private Article GetArticle(Guid articleId)
        {
            return _context.Articles.Include(x => x.Like).FirstOrDefault(x => x.Id == articleId);
        }

        public async Task<int> AddLikeToArticle(Guid articleId, string userIp)
        {
            var article = GetArticle(articleId);

            if (article == null || _context.Likes.Any(x => x.UserIP == userIp && x.Article.Id == articleId))
                return -1;

            var like = new Like
            {
                Id = Guid.NewGuid(),
                Article = article,
                UserIP = userIp
            };

            _context.Likes.Add(like);
            await _context.Commit();

            return GetArticle(articleId).Like.Count;
        }

        public void Dispose()
        {
            _context?.Dispose();
        }

        
    }
}
