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
        public async Task<IEnumerable<Article>> GetAllArticles()
        {
            return await _articleRepository.GetAll();
        }

        [Route("updateLikeButtonCount")]
        [HttpPost]
        [ProducesResponseType(200)]
        [ProducesResponseType(204)]
        public async Task<int> UpdateLikeButtonCount([FromBody] Guid ArticleId)
        {
            return await _articleRepository.UpdateLikeCount(ArticleId);
        }
    }
}

