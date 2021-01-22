using LikeButtonProject.ButtonService.Data;
using LikeButtonProject.ButtonService.Data.Repository;
using LikeButtonProject.ButtonService.Models;
using Microsoft.Extensions.DependencyInjection;

namespace LikeButtonProject.ButtonService.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IArticleRepository, ArticleRepository>();
            services.AddScoped<DataContext>();
        }
    }
}
