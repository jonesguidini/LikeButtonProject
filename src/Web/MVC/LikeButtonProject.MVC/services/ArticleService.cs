using LikeButtonProject.MVC.Extensions;
using LikeButtonProject.MVC.Models;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace LikeButtonProject.MVC.services
{
    public class ArticleService : Service, IArticleService
    {

        private readonly HttpClient _httpClient;

        public ArticleService(HttpClient httpClient,
            IOptions<AppSettings> settings)
        {
            httpClient.BaseAddress = new Uri(settings.Value.ArticleAPIUrl);

            _httpClient = httpClient;
        }

        public async Task<IEnumerable<ArticleViewModel>> GetAll()
        {
            var response = await _httpClient.GetAsync("/api/getAll");

            TratarErrosResponse(response);

            return await DeserializarObjetoResponse<IEnumerable<ArticleViewModel>>(response);
        }

        public async Task<int> UpdateLikeCount(Guid id)
        {
            var ArticleId = ObterConteudo(id);

            var response = await _httpClient.PostAsync("/api/updateLikeButtonCount", ArticleId);

            TratarErrosResponse(response);

            return await DeserializarObjetoResponse<int>(response);
        }
    }
}
