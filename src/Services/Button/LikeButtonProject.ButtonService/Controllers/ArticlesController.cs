using LikeButtonProject.ButtonService.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LikeButtonProject.ButtonService.Controllers
{
    [ApiController]
    [Route("api")]
    public class ArticlesController
    {
        private readonly IArticleRepository _articleRepository;

        public ArticlesController(IArticleRepository articleRepository)
        {
            _articleRepository = articleRepository;
        }

        [Route("getAll")]
        [HttpGet]
        [ProducesResponseType(200)]
        public async Task<IEnumerable<ArticleDTO>> GetAllArticles()
        {
            var result = await _articleRepository.GetAll();

            var dtoList = new List<ArticleDTO>();

            foreach (var item in result)
            {
                var dto = new ArticleDTO
                {
                    Id = item.Id,
                    ArticleContent = item.ArticleContent,
                    CreatedAt = item.CreatedAt,
                    LastLikeAction = item.CreatedAt,
                    Title = item.Title,
                    LikesCount = item.Like.Count
                };

                dtoList.Add(dto);
            }

            return dtoList;
        }

        [Route("addLikeArticle/{ArticleId}/{userIp}")]
        [HttpPost]
        [ProducesResponseType(200)]
        [ProducesResponseType(204)]
        public async Task<int> AddLikeArticle(Guid ArticleId, string userIp)
        {
            return await _articleRepository.AddLikeToArticle(ArticleId, userIp);
        }
    }
}

