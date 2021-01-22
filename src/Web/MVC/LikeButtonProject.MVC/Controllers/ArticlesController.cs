using LikeButtonProject.MVC.services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace LikeButtonProject.MVC.Controllers
{
    public class ArticlesController : Controller
    {

        private readonly IArticleService _articleService;

        public ArticlesController(IArticleService articleService)
        {
            _articleService = articleService;
        }

        [HttpGet]
        
        public async Task<IActionResult> Index()
        {
            var produtos = await _articleService.GetAll();
            return View(produtos);
        }

        [HttpPost]
        [Route("updateLikeCount/{id}")]
        public async Task<int> UpdateLikeCount(string id)
        {
            var idGuid = Guid.Parse(id);
            var response = await _articleService.UpdateLikeCount(idGuid);
            return response;
        }
    }
}
